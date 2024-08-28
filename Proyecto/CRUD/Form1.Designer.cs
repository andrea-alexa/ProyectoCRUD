namespace CRUD
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label8 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtFax = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPostalCode = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtRegion = new System.Windows.Forms.TextBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtContactTitle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.btnCargarInfo = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.txtContactName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(890, 564);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 16);
            this.label8.TabIndex = 28;
            this.label8.Text = "Fax";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(1004, 516);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(185, 22);
            this.txtPhone.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(890, 521);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 16);
            this.label9.TabIndex = 27;
            this.label9.Text = "Phone";
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(1004, 473);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(185, 22);
            this.txtCountry.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(890, 255);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 16);
            this.label10.TabIndex = 21;
            this.label10.Text = "ContactTitle";
            // 
            // txtFax
            // 
            this.txtFax.Location = new System.Drawing.Point(1004, 564);
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(185, 22);
            this.txtFax.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(890, 475);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 16);
            this.label11.TabIndex = 26;
            this.label11.Text = "Country";
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.Location = new System.Drawing.Point(1004, 427);
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(185, 22);
            this.txtPostalCode.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(890, 430);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 16);
            this.label12.TabIndex = 25;
            this.label12.Text = "PostalCode";
            // 
            // txtRegion
            // 
            this.txtRegion.Location = new System.Drawing.Point(1004, 382);
            this.txtRegion.Name = "txtRegion";
            this.txtRegion.Size = new System.Drawing.Size(185, 22);
            this.txtRegion.TabIndex = 9;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(1015, 637);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(93, 38);
            this.btnModificar.TabIndex = 15;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(1133, 637);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(93, 38);
            this.btnEliminar.TabIndex = 16;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(899, 637);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(93, 38);
            this.btnAgregar.TabIndex = 14;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(890, 386);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 16);
            this.label7.TabIndex = 24;
            this.label7.Text = "Region";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(1004, 338);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(185, 22);
            this.txtCity.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(890, 343);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 16);
            this.label6.TabIndex = 23;
            this.label6.Text = "City";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(1004, 295);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(185, 22);
            this.txtAddress.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(890, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "Address";
            // 
            // txtContactTitle
            // 
            this.txtContactTitle.Location = new System.Drawing.Point(1004, 252);
            this.txtContactTitle.Name = "txtContactTitle";
            this.txtContactTitle.Size = new System.Drawing.Size(185, 22);
            this.txtContactTitle.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(890, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "ContactName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(890, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "CompanyName";
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(1004, 160);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(185, 22);
            this.txtCompanyName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(890, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "CustomerID";
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(1004, 115);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(185, 22);
            this.txtCustomerID.TabIndex = 3;
            // 
            // btnCargarInfo
            // 
            this.btnCargarInfo.Location = new System.Drawing.Point(355, 702);
            this.btnCargarInfo.Name = "btnCargarInfo";
            this.btnCargarInfo.Size = new System.Drawing.Size(198, 46);
            this.btnCargarInfo.TabIndex = 0;
            this.btnCargarInfo.Text = "Cargar Informacion";
            this.btnCargarInfo.UseVisualStyleBackColor = true;
            this.btnCargarInfo.Click += new System.EventHandler(this.btnCargarInfo_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(1054, 55);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(1004, 27);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(185, 22);
            this.txtBuscar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(890, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "CustomerID";
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(46, 27);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowHeadersWidth = 51;
            this.dataGrid.RowTemplate.Height = 24;
            this.dataGrid.Size = new System.Drawing.Size(829, 648);
            this.dataGrid.TabIndex = 29;
            // 
            // txtContactName
            // 
            this.txtContactName.Location = new System.Drawing.Point(1004, 207);
            this.txtContactName.Name = "txtContactName";
            this.txtContactName.Size = new System.Drawing.Size(185, 22);
            this.txtContactName.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 775);
            this.Controls.Add(this.txtContactName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtFax);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtPostalCode);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtRegion);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtContactTitle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCompanyName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.btnCargarInfo);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGrid);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customers";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtFax;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPostalCode;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtRegion;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtContactTitle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.Button btnCargarInfo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.TextBox txtContactName;
    }
}

