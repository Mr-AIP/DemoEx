namespace DemoExam.Forms
{
    partial class OrdersForm
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
            this.dataGridViewOrders = new System.Windows.Forms.DataGridView();
            this.buttonAddOrders = new System.Windows.Forms.Button();
            this.buttonEditOrder = new System.Windows.Forms.Button();
            this.buttonDeleteOrder = new System.Windows.Forms.Button();
            this.buttonEqipStatus = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewOrders
            // 
            this.dataGridViewOrders.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGridViewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrders.Location = new System.Drawing.Point(13, 13);
            this.dataGridViewOrders.Name = "dataGridViewOrders";
            this.dataGridViewOrders.RowHeadersWidth = 51;
            this.dataGridViewOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOrders.Size = new System.Drawing.Size(775, 306);
            this.dataGridViewOrders.TabIndex = 0;
            this.dataGridViewOrders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOrders_CellContentClick);
            // 
            // buttonAddOrders
            // 
            this.buttonAddOrders.Location = new System.Drawing.Point(13, 326);
            this.buttonAddOrders.Name = "buttonAddOrders";
            this.buttonAddOrders.Size = new System.Drawing.Size(237, 112);
            this.buttonAddOrders.TabIndex = 1;
            this.buttonAddOrders.Text = "Добавить новую заявку";
            this.buttonAddOrders.UseVisualStyleBackColor = true;
            this.buttonAddOrders.Click += new System.EventHandler(this.buttonAddOrders_Click);
            // 
            // buttonEditOrder
            // 
            this.buttonEditOrder.Location = new System.Drawing.Point(257, 326);
            this.buttonEditOrder.Name = "buttonEditOrder";
            this.buttonEditOrder.Size = new System.Drawing.Size(284, 112);
            this.buttonEditOrder.TabIndex = 2;
            this.buttonEditOrder.Text = "Изменить заявку";
            this.buttonEditOrder.UseVisualStyleBackColor = true;
            this.buttonEditOrder.Click += new System.EventHandler(this.buttonEditOrder_Click);
            // 
            // buttonDeleteOrder
            // 
            this.buttonDeleteOrder.Location = new System.Drawing.Point(547, 326);
            this.buttonDeleteOrder.Name = "buttonDeleteOrder";
            this.buttonDeleteOrder.Size = new System.Drawing.Size(241, 112);
            this.buttonDeleteOrder.TabIndex = 3;
            this.buttonDeleteOrder.Text = "Удалить заявку";
            this.buttonDeleteOrder.UseVisualStyleBackColor = true;
            this.buttonDeleteOrder.Click += new System.EventHandler(this.buttonDeleteOrder_Click);
            // 
            // buttonEqipStatus
            // 
            this.buttonEqipStatus.Location = new System.Drawing.Point(547, 326);
            this.buttonEqipStatus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonEqipStatus.Name = "buttonEqipStatus";
            this.buttonEqipStatus.Size = new System.Drawing.Size(241, 112);
            this.buttonEqipStatus.TabIndex = 4;
            this.buttonEqipStatus.Text = "Изменить статус";
            this.buttonEqipStatus.UseVisualStyleBackColor = true;
            this.buttonEqipStatus.Click += new System.EventHandler(this.buttonEqipStatus_Click);
            // 
            // OrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonEqipStatus);
            this.Controls.Add(this.buttonDeleteOrder);
            this.Controls.Add(this.buttonEditOrder);
            this.Controls.Add(this.buttonAddOrders);
            this.Controls.Add(this.dataGridViewOrders);
            this.Name = "OrdersForm";
            this.Text = "Редактирование ";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewOrders;
        private System.Windows.Forms.Button buttonAddOrders;
        private System.Windows.Forms.Button buttonEditOrder;
        private System.Windows.Forms.Button buttonDeleteOrder;
        private System.Windows.Forms.Button buttonEqipStatus;
    }
}