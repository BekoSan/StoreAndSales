using StoreAndSalesLibrary.DataAccess;
using StoreAndSalesLibrary.Models;
using StoreAndSalesUI.Helpers;
using StoreAndSalesUI.Interfaces;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace StoreAndSalesUI.Forms
{
    public partial class ChooseUnitForm : Form
    {
        public ChooseUnitForm()
        {
            InitializeComponent();
        }

        public ChooseUnitForm(IUnitRequester caller)
        {
            InitializeComponent();
            CallingForm = caller;
        }

        #region Private Members

        private UnitData _unitData = new UnitData();
        private Unit _unit = new Unit();
        private List<Unit> Units = new List<Unit>();
        private IUnitRequester CallingForm;

        #endregion

        #region Private Methods

        private void LoadUnits()
        {
            Units = _unitData.GetAllUnits();
            itemUnitsDataGridView.AutoGenerateColumns = false;
            itemUnitsDataGridView.DataSource = Units;
        }

        private void SelectUnit()
        {
            _unit.Id = itemUnitsDataGridView.CurrentRow.Cells[0].Value.ToString().ParseToInt();
            _unit.UnitName = itemUnitsDataGridView.CurrentRow.Cells[2].Value.ToString();
            if (CallingForm != null) CallingForm.AddUnit(_unit);
            Close();
        }

        #endregion

        private void itemUnitsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 1) return;
            SelectUnit();
        }

        private void ChooseUnitForm_Load(object sender, EventArgs e)
        {
            LoadUnits();
        }

    }
}
