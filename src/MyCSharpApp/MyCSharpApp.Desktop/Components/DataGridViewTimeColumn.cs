using System;
using System.Windows.Forms;

namespace MyCSharpApp.Desktop.Components
{
    public class DataGridViewTimeColumn : DataGridViewColumn
    {
        public DataGridViewTimeColumn() : base()
        {
            base.CellTemplate = new DataGridViewTimeCell();
        }

        public override DataGridViewCell CellTemplate
        {
            get => base.CellTemplate;
            set
            {
                if (!((value == null)) && !(value.GetType().IsAssignableFrom(typeof(DataGridViewTimeCell))))
                {
                    throw new InvalidCastException("Must be a DataGridViewTimeCell");
                }
                base.CellTemplate = value;
            }
        }
    }
    public class DataGridViewTimeCell : DataGridViewTextBoxCell
    {
        public DataGridViewTimeCell()
        {
            Style.Format = "hh:mm tt";
        }
        public override void InitializeEditingControl(int rowIndex, object initialFormattedValue, DataGridViewCellStyle dataGridViewCellStyle)
        {
            base.InitializeEditingControl(rowIndex, initialFormattedValue, dataGridViewCellStyle);

            var DataGridViewTimeEditingControl = (DataGridViewTimeEditingControl)DataGridView.EditingControl;
            if (RowIndex >= 0)
            {
                if (!(object.ReferenceEquals(Value, DBNull.Value)))
                {
                    if (Value == null) return;

                    if (Value != "")
                    {
                        try
                        {
                            DataGridViewTimeEditingControl.Value = DateTime.Parse(Value.ToString());
                        }
                        catch (Exception)
                        {
                            // ignored
                        }
                    }
                }
            }
        }

        public override Type EditType => typeof(DataGridViewTimeEditingControl);
        public override Type ValueType => typeof(DateTime);
        public override object DefaultNewRowValue => DateTime.Now.ToShortTimeString();
    }
    internal class DataGridViewTimeEditingControl : DateTimePicker, IDataGridViewEditingControl
    {
        private DataGridView dataGridViewControl;
        private bool valueIsChanged = false;
        private int rowIndexNum;

        public DataGridViewTimeEditingControl()
        {
            Format = DateTimePickerFormat.Time;
        }
        public object EditingControlFormattedValue
        {
            get => Value.ToShortTimeString();
            set
            {
                if (value is string)
                {
                    Value = DateTime.Parse(Convert.ToString(value));
                }
            }
        }
        public object GetEditingControlFormattedValue(DataGridViewDataErrorContexts context)
        {
            return Value.ToShortTimeString();
        }
        public void ApplyCellStyleToEditingControl(DataGridViewCellStyle dataGridViewCellStyle)
        {
            Font = dataGridViewCellStyle.Font;
            ShowUpDown = true;
            CalendarForeColor = dataGridViewCellStyle.ForeColor;
            CalendarMonthBackground = dataGridViewCellStyle.BackColor;
        }

        public int EditingControlRowIndex
        {
            get => rowIndexNum;
            set => rowIndexNum = value;
        }

        public bool EditingControlWantsInputKey(Keys key, bool dataGridViewWantsInputKey)
        {
            switch (key)
            {
                case Keys.Left:
                case Keys.Up:
                case Keys.Down:
                case Keys.Right:
                case Keys.Home:
                case Keys.End:
                case Keys.PageDown:
                case Keys.PageUp:
                    return true;

                default:
                    return false;
            }
        }

        public void PrepareEditingControlForEdit(bool selectAll)
        {
        }

        public bool RepositionEditingControlOnValueChange => false;

        public DataGridView EditingControlDataGridView
        {
            get => dataGridViewControl;
            set => dataGridViewControl = value;
        }

        public bool EditingControlValueChanged
        {
            get => valueIsChanged;
            set => valueIsChanged = value;
        }

        public Cursor EditingControlCursor => base.Cursor;

        protected override void OnValueChanged(EventArgs ea)
        {
            valueIsChanged = true;
            this.EditingControlDataGridView.NotifyCurrentCellDirty(true);
            base.OnValueChanged(ea);
        }
        Cursor IDataGridViewEditingControl.EditingPanelCursor => IDataGridViewEditingControl_EditingPanelCursor;

        private Cursor IDataGridViewEditingControl_EditingPanelCursor =>
            //throw new Exception("The method or operation is not implemented."); }
            base.Cursor;
    }
}