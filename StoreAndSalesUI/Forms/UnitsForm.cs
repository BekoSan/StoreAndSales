using StoreAndSalesLibrary.DataAccess;
using StoreAndSalesLibrary.Models;
using StoreAndSalesUI.Helpers;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace StoreAndSalesUI.Forms
{
    public partial class UnitsForm : Form
    {
        public UnitsForm()
        {
            InitializeComponent();
        }

        #region Private Members

        private UnitData _unitData = new UnitData();
        private Unit _unit = new Unit();
        private List<Unit> Units = new List<Unit>();
        private UserLogData _userLogData = new UserLogData();

        #endregion

        #region Private Methods

        private void LoadUnits()
        {
            Units = _unitData.GetAllUnits();
            unitsDataGridView.AutoGenerateColumns = false;
            unitsDataGridView.DataSource = Units;
        }

        private void SelectUnit()
        {
            _unit.Id = unitsDataGridView.CurrentRow.Cells[0].Value.ToString().ParseToInt();
            _unit.UnitName = unitsDataGridView.CurrentRow.Cells[1].Value.ToString();
        }

        private void LoadUnitData()
        {
            unitNameTextBox.Text = _unit.UnitName;
        }

        private void ClearForm()
        {
            _unit = new Unit();
            unitNameTextBox.Clear();
        }

        private void CollectData()
        {
            _unit.UnitName = unitNameTextBox.Text;
        }

        private bool IsValidData()
        {
            bool output = true;

            if (_unit.UnitName.Length == 0)
            {
                MessageBox.Show("يجب إدخال إسم الوحــدة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                output = false;
                unitNameTextBox.Focus();
            }
            return output;
        }

        private void Save()
        {
            try
            {
                if (_unit.Id != 0)
                {
                    if (MessageBox.Show("سيتم تعديل البيانات ، هل أنت متأكد؟", "تأكيد التعديل",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                 MessageBoxDefaultButton.Button2) == DialogResult.No) return;
                    _unitData.EditUnit(_unit);
                    _userLogData.AddLog(LoginDataHelper.UserId, $"تم تعديل الوحدة {_unit.UnitName}");
                    MessageBox.Show("تم التعديل بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    _unitData.CreateUnit(_unit);
                    _userLogData.AddLog(LoginDataHelper.UserId, $"تمت إضافة الوحدة {_unit.UnitName}");
                    MessageBox.Show("تمت الإضافة بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                UsefulMethods.LogException(ex);
            }
        }

        private void ResetForm()
        {
            ClearForm();
            LoadUnits();
        }

        #endregion

        private void UnitsForm_Load(object sender, System.EventArgs e)
        {
            LoadUnits();
        }

        private void unitsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectUnit();
            LoadUnitData(); 
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            ResetForm(); 
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            CollectData();
            if (IsValidData()) Save();
            ResetForm();
        }

    }
}
