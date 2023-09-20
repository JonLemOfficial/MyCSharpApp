using System;
//using System.Drawing;
using System.Windows.Forms;

namespace MyCSharpApp.Desktop.Components
{
    public class DataGridViewNumericColumn : DataGridViewColumn
    {
        public DataGridViewNumericColumn() : base()
        {
            base.CellTemplate = new DataGridViewNumericCell();
        }
        
        public override DataGridViewCell CellTemplate
        {
            get => base.CellTemplate;
            set
            {
                if (!((value == null)) && !(value.GetType().IsAssignableFrom(typeof(DataGridViewNumericCell))))
                {
                    throw new InvalidCastException("Must be a DataGridViewNumericCell");
                }
                base.CellTemplate = value;
            }
        }
    }
    public class DataGridViewNumericCell : DataGridViewTextBoxCell
    {

        //private const int ArrowButtonWidth = 17;

        public DataGridViewNumericCell()
        {
            this.Style.Format = "N";
            this.Value = 0;
        }

        public DataGridViewNumericCell(int NumValue)
        {
            this.Style.Format = "N";
            this.Value = NumValue;
        }

        public override Type EditType => typeof(DataGridViewNumericEditingControl);

        public override Type ValueType => typeof(int);

        public override object DefaultNewRowValue => 0;

        public override void InitializeEditingControl(int rowIndex, object initialFormattedValue, DataGridViewCellStyle dataGridViewCellStyle)
        {
            base.InitializeEditingControl(rowIndex, initialFormattedValue, dataGridViewCellStyle);

            var DataGridViewNumericEditingControl = (DataGridViewNumericEditingControl) DataGridView.EditingControl;
            if (RowIndex >= 0)
            {
                if (!(object.ReferenceEquals(this.Value, DBNull.Value)))
                {
                    if (Value == null) return;

                    if (Value != "")
                    {
                        try
                        {
                            DataGridViewNumericEditingControl.Value = Convert.ToDecimal(this.Value.ToString());
                        }
                        catch (Exception err)
                        {
                            // ignored
                        }
                    }
                }
            }
        }

        //protected override void Paint(Graphics graphics, Rectangle clipBounds, Rectangle cellBounds, int rowIndex, DataGridViewElementStates cellState, object value, object formattedValue, string errorText, DataGridViewCellStyle cellStyle, DataGridViewAdvancedBorderStyle advancedBorderStyle, DataGridViewPaintParts paintParts)
        //{
        //    base.Paint(
        //        graphics,
        //        clipBounds,
        //        cellBounds,
        //        rowIndex,
        //        cellState,
        //        value,
        //        formattedValue,
        //        errorText,
        //        cellStyle,
        //        advancedBorderStyle,
        //        paintParts
        //    );

        //    var buttonBounds = new Rectangle(
        //        cellBounds.Right - ArrowButtonWidth,
        //        cellBounds.Top,
        //        ArrowButtonWidth,
        //        cellBounds.Height
        //    );

        //    ControlPaint.DrawButton(graphics, buttonBounds, ButtonState.Normal);

        //    var upButtonBounds = new Rectangle(buttonBounds.Left + 1, buttonBounds.Top + 1, buttonBounds.Width - 2, buttonBounds.Height / 2 - 1);
        //    var downButtonBounds = new Rectangle(buttonBounds.Left + 1, buttonBounds.Top + buttonBounds.Height / 2, buttonBounds.Width - 2, buttonBounds.Height / 2 - 1);

        //    ControlPaint.DrawScrollButton(graphics, upButtonBounds, ScrollButton.Up, ButtonState.Normal);
        //    ControlPaint.DrawScrollButton(graphics, downButtonBounds, ScrollButton.Down, ButtonState.Normal);
        //}

        public override object Clone()
        {
            // Crea una copia de la celda
            var clone = base.Clone() as DataGridViewNumericCell;
            return clone;
        }
    }

    internal class DataGridViewNumericEditingControl : NumericUpDown, IDataGridViewEditingControl
    {
        private DataGridView dataGridViewControl;
        private bool valueIsChanged = false;
        private int rowIndexNum;

        public DataGridViewNumericEditingControl()
        {
            
        }
        
        public object EditingControlFormattedValue
        {
            get => Value.ToString();
            set
            {
                if (value is string)
                {
                    Value = Convert.ToDecimal(value);
                }
            }
        }

        public object GetEditingControlFormattedValue(DataGridViewDataErrorContexts context)
        {
            return Value.ToString();
        }

        public void ApplyCellStyleToEditingControl(DataGridViewCellStyle dataGridViewCellStyle)
        {
            Font = dataGridViewCellStyle.Font;
            ForeColor = dataGridViewCellStyle.ForeColor;
            BackColor = dataGridViewCellStyle.BackColor;
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

        protected override void OnLeave(EventArgs e)
        {
            // Notifica al control DataGridView cuando el control de edición pierde el foco
            if (this.dataGridViewControl != null && this.valueIsChanged)
            {
                this.dataGridViewControl.NotifyCurrentCellDirty(true);
                this.valueIsChanged = false;
            }
            base.OnLeave(e);
        }
    }
}