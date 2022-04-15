﻿
namespace RentMe.View
{
    partial class ViewCartDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cartDataGrideView = new System.Windows.Forms.DataGridView();
            this.rentAmountlabel = new System.Windows.Forms.Label();
            this.amountLabel = new System.Windows.Forms.Label();
            this.cancelCartButton = new System.Windows.Forms.Button();
            this.submitOrderButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.emptyCartButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.UpdateItem = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DeleteItem = new System.Windows.Forms.DataGridViewButtonColumn();
            this.furnitureIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.styleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentalAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dueDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.furnitureRentQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalItemRentalAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentFurnitureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.cartDataGrideView)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rentFurnitureBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cartDataGrideView
            // 
            this.cartDataGrideView.AutoGenerateColumns = false;
            this.cartDataGrideView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.cartDataGrideView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cartDataGrideView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.furnitureIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.styleDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.rentalAmountDataGridViewTextBoxColumn,
            this.dueDateDataGridViewTextBoxColumn,
            this.furnitureRentQuantityDataGridViewTextBoxColumn,
            this.totalItemRentalAmountDataGridViewTextBoxColumn,
            this.DeleteItem,
            this.UpdateItem});
            this.cartDataGrideView.DataSource = this.rentFurnitureBindingSource;
            this.cartDataGrideView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cartDataGrideView.Location = new System.Drawing.Point(3, 61);
            this.cartDataGrideView.Name = "cartDataGrideView";
            this.cartDataGrideView.RowHeadersWidth = 51;
            this.cartDataGrideView.RowTemplate.Height = 24;
            this.cartDataGrideView.Size = new System.Drawing.Size(1261, 189);
            this.cartDataGrideView.TabIndex = 0;
            this.cartDataGrideView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CartDataGrideView_CellContentClick);
            // 
            // rentAmountlabel
            // 
            this.rentAmountlabel.AutoSize = true;
            this.rentAmountlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentAmountlabel.Location = new System.Drawing.Point(3, 0);
            this.rentAmountlabel.Name = "rentAmountlabel";
            this.rentAmountlabel.Size = new System.Drawing.Size(241, 29);
            this.rentAmountlabel.TabIndex = 1;
            this.rentAmountlabel.Text = "Total Amount to Pay- ";
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountLabel.Location = new System.Drawing.Point(384, 0);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(61, 25);
            this.amountLabel.TabIndex = 2;
            this.amountLabel.Text = "$0.00";
            // 
            // cancelCartButton
            // 
            this.cancelCartButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelCartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelCartButton.Location = new System.Drawing.Point(787, 3);
            this.cancelCartButton.Name = "cancelCartButton";
            this.cancelCartButton.Size = new System.Drawing.Size(124, 39);
            this.cancelCartButton.TabIndex = 3;
            this.cancelCartButton.Text = "Cancel";
            this.cancelCartButton.UseVisualStyleBackColor = true;
            // 
            // submitOrderButton
            // 
            this.submitOrderButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.submitOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitOrderButton.Location = new System.Drawing.Point(511, 3);
            this.submitOrderButton.Name = "submitOrderButton";
            this.submitOrderButton.Size = new System.Drawing.Size(189, 39);
            this.submitOrderButton.TabIndex = 4;
            this.submitOrderButton.Text = "Submit Rent Order";
            this.submitOrderButton.UseVisualStyleBackColor = true;
            this.submitOrderButton.Click += new System.EventHandler(this.SubmitOrderButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(483, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Remove Items";
            this.button1.UseVisualStyleBackColor = true;
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.cartDataGrideView, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1267, 450);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // emptyCartButton
            // 
            this.emptyCartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emptyCartButton.Location = new System.Drawing.Point(1017, 3);
            this.emptyCartButton.Name = "emptyCartButton";
            this.emptyCartButton.Size = new System.Drawing.Size(210, 39);
            this.emptyCartButton.TabIndex = 5;
            this.emptyCartButton.Text = "Empty Your Cart";
            this.emptyCartButton.UseVisualStyleBackColor = true;
            this.emptyCartButton.Click += new System.EventHandler(this.EmptyCartButton_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.23697F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.71386F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 236F));
            this.tableLayoutPanel2.Controls.Add(this.emptyCartButton, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.rentAmountlabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.amountLabel, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.cancelCartButton, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.submitOrderButton, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 256);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1252, 58);
            this.tableLayoutPanel2.TabIndex = 6;
            // UpdateItem
            // 
            this.UpdateItem.HeaderText = "Update";
            this.UpdateItem.MinimumWidth = 6;
            this.UpdateItem.Name = "UpdateItem";
            this.UpdateItem.Text = "Update";
            this.UpdateItem.UseColumnTextForButtonValue = true;
            this.UpdateItem.Width = 60;
            // 
            // DeleteItem
            // 
            this.DeleteItem.HeaderText = "Delete";
            this.DeleteItem.MinimumWidth = 6;
            this.DeleteItem.Name = "DeleteItem";
            this.DeleteItem.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DeleteItem.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.DeleteItem.Text = "Delete";
            this.DeleteItem.UseColumnTextForButtonValue = true;
            this.DeleteItem.Width = 78;
            // 
            // furnitureIDDataGridViewTextBoxColumn
            // 
            this.furnitureIDDataGridViewTextBoxColumn.DataPropertyName = "FurnitureID";
            this.furnitureIDDataGridViewTextBoxColumn.HeaderText = "FurnitureID";
            this.furnitureIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.furnitureIDDataGridViewTextBoxColumn.Name = "furnitureIDDataGridViewTextBoxColumn";
            this.furnitureIDDataGridViewTextBoxColumn.Width = 107;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 74;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            this.categoryDataGridViewTextBoxColumn.Width = 94;
            // 
            // styleDataGridViewTextBoxColumn
            // 
            this.styleDataGridViewTextBoxColumn.DataPropertyName = "Style";
            this.styleDataGridViewTextBoxColumn.HeaderText = "Style";
            this.styleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.styleDataGridViewTextBoxColumn.Name = "styleDataGridViewTextBoxColumn";
            this.styleDataGridViewTextBoxColumn.Width = 68;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.Width = 108;
            // 
            // rentalAmountDataGridViewTextBoxColumn
            // 
            this.rentalAmountDataGridViewTextBoxColumn.DataPropertyName = "RentalAmount";
            this.rentalAmountDataGridViewTextBoxColumn.HeaderText = "RentalAmount";
            this.rentalAmountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rentalAmountDataGridViewTextBoxColumn.Name = "rentalAmountDataGridViewTextBoxColumn";
            this.rentalAmountDataGridViewTextBoxColumn.Width = 126;
            // 
            // dueDateDataGridViewTextBoxColumn
            // 
            this.dueDateDataGridViewTextBoxColumn.DataPropertyName = "DueDate";
            this.dueDateDataGridViewTextBoxColumn.HeaderText = "DueDate";
            this.dueDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dueDateDataGridViewTextBoxColumn.Name = "dueDateDataGridViewTextBoxColumn";
            this.dueDateDataGridViewTextBoxColumn.Width = 93;
            // 
            // furnitureRentQuantityDataGridViewTextBoxColumn
            // 
            this.furnitureRentQuantityDataGridViewTextBoxColumn.DataPropertyName = "FurnitureRentQuantity";
            this.furnitureRentQuantityDataGridViewTextBoxColumn.HeaderText = "FurnitureRentQuantity";
            this.furnitureRentQuantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.furnitureRentQuantityDataGridViewTextBoxColumn.Name = "furnitureRentQuantityDataGridViewTextBoxColumn";
            this.furnitureRentQuantityDataGridViewTextBoxColumn.Width = 177;
            // 
            // totalItemRentalAmountDataGridViewTextBoxColumn
            // 
            this.totalItemRentalAmountDataGridViewTextBoxColumn.DataPropertyName = "TotalItemRentalAmount";
            this.totalItemRentalAmountDataGridViewTextBoxColumn.HeaderText = "TotalItemRentalAmount";
            this.totalItemRentalAmountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalItemRentalAmountDataGridViewTextBoxColumn.Name = "totalItemRentalAmountDataGridViewTextBoxColumn";
            this.totalItemRentalAmountDataGridViewTextBoxColumn.Width = 184;
            // 
            // rentFurnitureBindingSource
            // 
            this.rentFurnitureBindingSource.DataSource = typeof(RentMe.Model.RentFurniture);
            // 
            // ViewCartDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.button1);
            this.Name = "ViewCartDialog";
            this.Text = "ViewCartDialog";
            this.Load += new System.EventHandler(this.ViewCartDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cartDataGrideView)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rentFurnitureBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView cartDataGrideView;
        private System.Windows.Forms.Label rentAmountlabel;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.Button cancelCartButton;
        private System.Windows.Forms.Button submitOrderButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource rentFurnitureBindingSource;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button emptyCartButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn furnitureIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn styleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentalAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dueDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn furnitureRentQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalItemRentalAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteItem;
        private System.Windows.Forms.DataGridViewButtonColumn UpdateItem;
    }
}