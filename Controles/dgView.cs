using System;
using System.Drawing;
using System.Windows.Forms;

namespace Setup.Controles
{
    public class dgView : DataGridView
    {
        protected override void OnCreateControl()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();

            this.AllowUserToAddRows = false;
            this.AllowUserToDeleteRows = false;

            //this.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSlateGray;

            //this.BorderStyle = BorderStyle.None;
            //this.GridColor = Color.FromArgb(25, 25, 26);
            this.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(37, 37, 38);
            this.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            this.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(37, 37, 38);
            this.ColumnHeadersDefaultCellStyle.Font = new Font(this.Font, FontStyle.Bold);

            dataGridViewCellStyle1.BackColor = Color.DarkGray;
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(37,37,38);
            dataGridViewCellStyle1.SelectionBackColor = Color.RoyalBlue;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            this.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.BackgroundColor = Color.FromArgb(37,37,38);
            this.BorderStyle = BorderStyle.None;
            this.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            this.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.DarkGray;
            dataGridViewCellStyle2.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(37,37,38);
            dataGridViewCellStyle2.SelectionBackColor = Color.DarkGray;
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(37,37,38);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            this.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(37,37,38);
            dataGridViewCellStyle3.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.RoyalBlue;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            this.DefaultCellStyle = dataGridViewCellStyle3;
            this.EditMode = DataGridViewEditMode.EditOnEnter;
            this.EnableHeadersVisualStyles = false;
            this.GridColor = Color.FromArgb(25, 25, 26);
            this.MultiSelect = false;
            this.ReadOnly = true;
            this.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(37,37,38);
            dataGridViewCellStyle4.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(37,37,38);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            this.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;

            dataGridViewCellStyle5.BackColor = Color.FromArgb(37,37,38);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.RoyalBlue;
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            this.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(37,37,38);
            this.RowTemplate.DefaultCellStyle.ForeColor = Color.White;
            this.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(25, 25, 26); ;
            this.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.White;
            this.RowTemplate.Height = 25;
            this.RowTemplate.Resizable = DataGridViewTriState.True;
            this.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.ShowEditingIcon = false;
            this.TabIndex = 1;

            base.OnCreateControl();
        }

        protected override void OnCellMouseMove(DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if(!this.MultiSelect)
                {
                    this.Rows[e.RowIndex].Selected = true;
                }
            }
            catch
            {

            }

            base.OnCellMouseMove(e);
        }

        protected override void OnLostFocus(EventArgs e)
        {
            this.ClearSelection();
            base.OnLostFocus(e);
        }

        protected override void OnDataBindingComplete(DataGridViewBindingCompleteEventArgs e)
        {
            this.ClearSelection();
            base.OnDataBindingComplete(e);
        }
    }
}
