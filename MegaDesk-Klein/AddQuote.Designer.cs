namespace MegaDesk_Klein
{
    partial class AddQuote
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
            this.AddReturnMainButton = new System.Windows.Forms.Button();
            this.CustomerFullName = new System.Windows.Forms.Label();
            this.NameInput = new System.Windows.Forms.TextBox();
            this.WidthInput = new System.Windows.Forms.TextBox();
            this.DepthInput = new System.Windows.Forms.TextBox();
            this.DeskWidth = new System.Windows.Forms.Label();
            this.DeskDepth = new System.Windows.Forms.Label();
            this.DrawerNumber = new System.Windows.Forms.Label();
            this.DrawersComboBox = new System.Windows.Forms.ComboBox();
            this.MaterialComboBox = new System.Windows.Forms.ComboBox();
            this.SurfaceMaterial = new System.Windows.Forms.Label();
            this.OrderProcessingTimeBox = new System.Windows.Forms.ComboBox();
            this.RushOrder = new System.Windows.Forms.Label();
            this.SubmitOrder = new System.Windows.Forms.Button();
            this.siteURL = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.WidthRequirements = new System.Windows.Forms.Label();
            this.DepthRequirements = new System.Windows.Forms.Label();
            this.errorProviderWidth = new System.Windows.Forms.ErrorProvider(this.components);
            this.dateToday = new System.Windows.Forms.Label();
            this.displayDateToday = new System.Windows.Forms.Label();
            this.errorProviderDepth = new System.Windows.Forms.ErrorProvider(this.components);
            this.standardLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDepth)).BeginInit();
            this.SuspendLayout();
            // 
            // AddReturnMainButton
            // 
            this.AddReturnMainButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(146)))), ((int)(((byte)(125)))));
            this.AddReturnMainButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddReturnMainButton.Location = new System.Drawing.Point(318, 564);
            this.AddReturnMainButton.Name = "AddReturnMainButton";
            this.AddReturnMainButton.Size = new System.Drawing.Size(200, 50);
            this.AddReturnMainButton.TabIndex = 7;
            this.AddReturnMainButton.Text = "Main Menu";
            this.AddReturnMainButton.UseVisualStyleBackColor = false;
            this.AddReturnMainButton.Click += new System.EventHandler(this.AddReturnMainButton_Click);
            // 
            // CustomerFullName
            // 
            this.CustomerFullName.AutoSize = true;
            this.CustomerFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerFullName.Location = new System.Drawing.Point(63, 215);
            this.CustomerFullName.Name = "CustomerFullName";
            this.CustomerFullName.Size = new System.Drawing.Size(224, 25);
            this.CustomerFullName.TabIndex = 1;
            this.CustomerFullName.Text = "Please enter your name:";
            // 
            // NameInput
            // 
            this.NameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameInput.Location = new System.Drawing.Point(318, 214);
            this.NameInput.Name = "NameInput";
            this.NameInput.Size = new System.Drawing.Size(200, 26);
            this.NameInput.TabIndex = 8;
            this.NameInput.TextChanged += new System.EventHandler(this.NameInput_TextChanged);
            this.NameInput.Validating += new System.ComponentModel.CancelEventHandler(this.Width_Validating);
            // 
            // WidthInput
            // 
            this.WidthInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WidthInput.Location = new System.Drawing.Point(318, 270);
            this.WidthInput.Name = "WidthInput";
            this.WidthInput.Size = new System.Drawing.Size(200, 26);
            this.WidthInput.TabIndex = 1;
            this.WidthInput.Validating += new System.ComponentModel.CancelEventHandler(this.Width_Validating);
            // 
            // DepthInput
            // 
            this.DepthInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepthInput.Location = new System.Drawing.Point(318, 325);
            this.DepthInput.Name = "DepthInput";
            this.DepthInput.Size = new System.Drawing.Size(200, 26);
            this.DepthInput.TabIndex = 2;
            this.DepthInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Depth_KeyPress);
            this.DepthInput.Validating += new System.ComponentModel.CancelEventHandler(this.Depth_Vallidating);
            // 
            // DeskWidth
            // 
            this.DeskWidth.AutoSize = true;
            this.DeskWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeskWidth.Location = new System.Drawing.Point(64, 271);
            this.DeskWidth.Name = "DeskWidth";
            this.DeskWidth.Size = new System.Drawing.Size(137, 25);
            this.DeskWidth.TabIndex = 5;
            this.DeskWidth.Text = "Width of desk:";
            // 
            // DeskDepth
            // 
            this.DeskDepth.AutoSize = true;
            this.DeskDepth.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeskDepth.Location = new System.Drawing.Point(64, 326);
            this.DeskDepth.Name = "DeskDepth";
            this.DeskDepth.Size = new System.Drawing.Size(138, 25);
            this.DeskDepth.TabIndex = 6;
            this.DeskDepth.Text = "Depth of desk:";
            // 
            // DrawerNumber
            // 
            this.DrawerNumber.AutoSize = true;
            this.DrawerNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DrawerNumber.Location = new System.Drawing.Point(64, 381);
            this.DrawerNumber.Name = "DrawerNumber";
            this.DrawerNumber.Size = new System.Drawing.Size(182, 25);
            this.DrawerNumber.TabIndex = 7;
            this.DrawerNumber.Text = "Number of drawers:";
            // 
            // DrawersComboBox
            // 
            this.DrawersComboBox.DisplayMember = "(none)";
            this.DrawersComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DrawersComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DrawersComboBox.FormattingEnabled = true;
            this.DrawersComboBox.IntegralHeight = false;
            this.DrawersComboBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.DrawersComboBox.Location = new System.Drawing.Point(318, 378);
            this.DrawersComboBox.Name = "DrawersComboBox";
            this.DrawersComboBox.Size = new System.Drawing.Size(200, 28);
            this.DrawersComboBox.TabIndex = 3;
            this.DrawersComboBox.SelectedIndexChanged += new System.EventHandler(this.DrawersComboBox_SelectedIndexChanged);
            // 
            // MaterialComboBox
            // 
            this.MaterialComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MaterialComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaterialComboBox.FormattingEnabled = true;
            this.MaterialComboBox.Location = new System.Drawing.Point(318, 433);
            this.MaterialComboBox.Name = "MaterialComboBox";
            this.MaterialComboBox.Size = new System.Drawing.Size(200, 28);
            this.MaterialComboBox.TabIndex = 4;
            this.MaterialComboBox.SelectedIndexChanged += new System.EventHandler(this.Material_ComboBox);
            // 
            // SurfaceMaterial
            // 
            this.SurfaceMaterial.AutoSize = true;
            this.SurfaceMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SurfaceMaterial.Location = new System.Drawing.Point(64, 436);
            this.SurfaceMaterial.Name = "SurfaceMaterial";
            this.SurfaceMaterial.Size = new System.Drawing.Size(137, 25);
            this.SurfaceMaterial.TabIndex = 10;
            this.SurfaceMaterial.Text = "Material Type:";
            // 
            // OrderProcessingTimeBox
            // 
            this.OrderProcessingTimeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OrderProcessingTimeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderProcessingTimeBox.FormattingEnabled = true;
            this.OrderProcessingTimeBox.Items.AddRange(new object[] {
            "3",
            "5",
            "7",
            "14"});
            this.OrderProcessingTimeBox.Location = new System.Drawing.Point(318, 486);
            this.OrderProcessingTimeBox.Name = "OrderProcessingTimeBox";
            this.OrderProcessingTimeBox.Size = new System.Drawing.Size(200, 28);
            this.OrderProcessingTimeBox.TabIndex = 5;
            this.OrderProcessingTimeBox.SelectedIndexChanged += new System.EventHandler(this.OrderProcessingTimeBox_SelectedIndexChanged);
            // 
            // RushOrder
            // 
            this.RushOrder.AutoSize = true;
            this.RushOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RushOrder.Location = new System.Drawing.Point(64, 489);
            this.RushOrder.Name = "RushOrder";
            this.RushOrder.Size = new System.Drawing.Size(219, 25);
            this.RushOrder.TabIndex = 12;
            this.RushOrder.Text = "Order Processing Time:";
            // 
            // SubmitOrder
            // 
            this.SubmitOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(146)))), ((int)(((byte)(125)))));
            this.SubmitOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitOrder.Location = new System.Drawing.Point(68, 564);
            this.SubmitOrder.Name = "SubmitOrder";
            this.SubmitOrder.Size = new System.Drawing.Size(200, 50);
            this.SubmitOrder.TabIndex = 6;
            this.SubmitOrder.Text = "Submit Order";
            this.SubmitOrder.UseVisualStyleBackColor = false;
            this.SubmitOrder.Click += new System.EventHandler(this.SubmitOrder_Click);
            // 
            // siteURL
            // 
            this.siteURL.AutoSize = true;
            this.siteURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siteURL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(80)))), ((int)(((byte)(63)))));
            this.siteURL.Location = new System.Drawing.Point(67, 120);
            this.siteURL.Name = "siteURL";
            this.siteURL.Size = new System.Drawing.Size(154, 20);
            this.siteURL.TabIndex = 15;
            this.siteURL.Text = "www.megadesk.com";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Agency FB", 70F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(80)))), ((int)(((byte)(63)))));
            this.title.Location = new System.Drawing.Point(49, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(340, 113);
            this.title.TabIndex = 14;
            this.title.Text = "MegaDesk";
            // 
            // WidthRequirements
            // 
            this.WidthRequirements.AutoSize = true;
            this.WidthRequirements.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WidthRequirements.Location = new System.Drawing.Point(66, 296);
            this.WidthRequirements.Name = "WidthRequirements";
            this.WidthRequirements.Size = new System.Drawing.Size(161, 17);
            this.WidthRequirements.TabIndex = 16;
            this.WidthRequirements.Text = "min 24 in and max 96 in.";
            // 
            // DepthRequirements
            // 
            this.DepthRequirements.AutoSize = true;
            this.DepthRequirements.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepthRequirements.Location = new System.Drawing.Point(66, 351);
            this.DepthRequirements.Name = "DepthRequirements";
            this.DepthRequirements.Size = new System.Drawing.Size(157, 17);
            this.DepthRequirements.TabIndex = 17;
            this.DepthRequirements.Text = "min 12 in and max 48 in";
            // 
            // errorProviderWidth
            // 
            this.errorProviderWidth.ContainerControl = this;
            // 
            // dateToday
            // 
            this.dateToday.AutoSize = true;
            this.dateToday.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateToday.Location = new System.Drawing.Point(64, 164);
            this.dateToday.Name = "dateToday";
            this.dateToday.Size = new System.Drawing.Size(120, 25);
            this.dateToday.TabIndex = 18;
            this.dateToday.Text = "Date Today:";
            // 
            // displayDateToday
            // 
            this.displayDateToday.AutoSize = true;
            this.displayDateToday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayDateToday.Location = new System.Drawing.Point(315, 164);
            this.displayDateToday.Name = "displayDateToday";
            this.displayDateToday.Size = new System.Drawing.Size(0, 20);
            this.displayDateToday.TabIndex = 19;
            // 
            // errorProviderDepth
            // 
            this.errorProviderDepth.ContainerControl = this;
            // 
            // standardLabel
            // 
            this.standardLabel.AutoSize = true;
            this.standardLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.standardLabel.Location = new System.Drawing.Point(66, 514);
            this.standardLabel.Name = "standardLabel";
            this.standardLabel.Size = new System.Drawing.Size(139, 17);
            this.standardLabel.TabIndex = 20;
            this.standardLabel.Text = "(Standard - 14 days)";
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 656);
            this.Controls.Add(this.standardLabel);
            this.Controls.Add(this.displayDateToday);
            this.Controls.Add(this.dateToday);
            this.Controls.Add(this.DepthRequirements);
            this.Controls.Add(this.WidthRequirements);
            this.Controls.Add(this.siteURL);
            this.Controls.Add(this.title);
            this.Controls.Add(this.SubmitOrder);
            this.Controls.Add(this.RushOrder);
            this.Controls.Add(this.OrderProcessingTimeBox);
            this.Controls.Add(this.SurfaceMaterial);
            this.Controls.Add(this.MaterialComboBox);
            this.Controls.Add(this.DrawersComboBox);
            this.Controls.Add(this.DrawerNumber);
            this.Controls.Add(this.DeskDepth);
            this.Controls.Add(this.DeskWidth);
            this.Controls.Add(this.DepthInput);
            this.Controls.Add(this.WidthInput);
            this.Controls.Add(this.NameInput);
            this.Controls.Add(this.CustomerFullName);
            this.Controls.Add(this.AddReturnMainButton);
            this.Name = "AddQuote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddQuote";
            this.Load += new System.EventHandler(this.AddQuote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDepth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddReturnMainButton;
        private System.Windows.Forms.Label CustomerFullName;
        private System.Windows.Forms.TextBox NameInput;
        private System.Windows.Forms.TextBox WidthInput;
        private System.Windows.Forms.TextBox DepthInput;
        private System.Windows.Forms.Label DeskWidth;
        private System.Windows.Forms.Label DeskDepth;
        private System.Windows.Forms.Label DrawerNumber;
        private System.Windows.Forms.ComboBox DrawersComboBox;
        private System.Windows.Forms.ComboBox MaterialComboBox;
        private System.Windows.Forms.Label SurfaceMaterial;
        private System.Windows.Forms.ComboBox OrderProcessingTimeBox;
        private System.Windows.Forms.Label RushOrder;
        private System.Windows.Forms.Button SubmitOrder;
        private System.Windows.Forms.Label siteURL;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label WidthRequirements;
        private System.Windows.Forms.Label DepthRequirements;
        private System.Windows.Forms.ErrorProvider errorProviderWidth;
        private System.Windows.Forms.Label displayDateToday;
        private System.Windows.Forms.Label dateToday;
        private System.Windows.Forms.ErrorProvider errorProviderDepth;
        private System.Windows.Forms.Label standardLabel;
    }
}