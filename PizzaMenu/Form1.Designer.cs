
namespace PizzaMenu
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoLargeSize = new System.Windows.Forms.RadioButton();
            this.rdoMediumSize = new System.Windows.Forms.RadioButton();
            this.rdoSmallSize = new System.Windows.Forms.RadioButton();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbMushroom = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbPepperoni = new System.Windows.Forms.CheckBox();
            this.cbBlackOlive = new System.Windows.Forms.CheckBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtOrder = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboDietary = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.orderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pizzaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.chkJuice = new System.Windows.Forms.CheckBox();
            this.chkCola = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chkChocCake = new System.Windows.Forms.CheckBox();
            this.chkApplePie = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoLargeSize);
            this.groupBox1.Controls.Add(this.rdoMediumSize);
            this.groupBox1.Controls.Add(this.rdoSmallSize);
            this.groupBox1.Location = new System.Drawing.Point(92, 28);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(148, 132);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pizza size";
            // 
            // rdoLargeSize
            // 
            this.rdoLargeSize.AutoSize = true;
            this.rdoLargeSize.Location = new System.Drawing.Point(29, 92);
            this.rdoLargeSize.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdoLargeSize.Name = "rdoLargeSize";
            this.rdoLargeSize.Size = new System.Drawing.Size(51, 19);
            this.rdoLargeSize.TabIndex = 2;
            this.rdoLargeSize.Text = "large";
            this.rdoLargeSize.UseVisualStyleBackColor = true;
            this.rdoLargeSize.CheckedChanged += new System.EventHandler(this.PizzaSize_CheckedChanged);
            // 
            // rdoMediumSize
            // 
            this.rdoMediumSize.AutoSize = true;
            this.rdoMediumSize.Location = new System.Drawing.Point(29, 65);
            this.rdoMediumSize.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdoMediumSize.Name = "rdoMediumSize";
            this.rdoMediumSize.Size = new System.Drawing.Size(70, 19);
            this.rdoMediumSize.TabIndex = 1;
            this.rdoMediumSize.Text = "medium";
            this.rdoMediumSize.UseVisualStyleBackColor = true;
            this.rdoMediumSize.CheckedChanged += new System.EventHandler(this.PizzaSize_CheckedChanged);
            // 
            // rdoSmallSize
            // 
            this.rdoSmallSize.AutoSize = true;
            this.rdoSmallSize.Location = new System.Drawing.Point(29, 37);
            this.rdoSmallSize.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdoSmallSize.Name = "rdoSmallSize";
            this.rdoSmallSize.Size = new System.Drawing.Size(53, 19);
            this.rdoSmallSize.TabIndex = 0;
            this.rdoSmallSize.Text = "small";
            this.rdoSmallSize.UseVisualStyleBackColor = true;
            this.rdoSmallSize.CheckedChanged += new System.EventHandler(this.PizzaSize_CheckedChanged);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(107, 320);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(116, 23);
            this.txtTotal.TabIndex = 1;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 323);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Total:";
            // 
            // cbMushroom
            // 
            this.cbMushroom.AutoSize = true;
            this.cbMushroom.Location = new System.Drawing.Point(26, 30);
            this.cbMushroom.Name = "cbMushroom";
            this.cbMushroom.Size = new System.Drawing.Size(116, 19);
            this.cbMushroom.TabIndex = 3;
            this.cbMushroom.Text = "Mushroom (+$2)";
            this.cbMushroom.UseVisualStyleBackColor = true;
            this.cbMushroom.CheckedChanged += new System.EventHandler(this.PizzaSize_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbPepperoni);
            this.groupBox2.Controls.Add(this.cbBlackOlive);
            this.groupBox2.Controls.Add(this.cbMushroom);
            this.groupBox2.Location = new System.Drawing.Point(92, 173);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(148, 125);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Toppings";
            // 
            // cbPepperoni
            // 
            this.cbPepperoni.AutoSize = true;
            this.cbPepperoni.Location = new System.Drawing.Point(26, 89);
            this.cbPepperoni.Name = "cbPepperoni";
            this.cbPepperoni.Size = new System.Drawing.Size(111, 19);
            this.cbPepperoni.TabIndex = 5;
            this.cbPepperoni.Text = "Pepperoni (+$5)";
            this.cbPepperoni.UseVisualStyleBackColor = true;
            this.cbPepperoni.CheckedChanged += new System.EventHandler(this.PizzaSize_CheckedChanged);
            // 
            // cbBlackOlive
            // 
            this.cbBlackOlive.AutoSize = true;
            this.cbBlackOlive.Location = new System.Drawing.Point(26, 58);
            this.cbBlackOlive.Name = "cbBlackOlive";
            this.cbBlackOlive.Size = new System.Drawing.Size(113, 19);
            this.cbBlackOlive.TabIndex = 4;
            this.cbBlackOlive.Text = "Black olive (+$3)";
            this.cbBlackOlive.UseVisualStyleBackColor = true;
            this.cbBlackOlive.CheckedChanged += new System.EventHandler(this.PizzaSize_CheckedChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Items.AddRange(new object[] {
            "Cheese",
            "Neapolitan",
            "Margherita",
            "Calzone",
            "Stromboli",
            "Deep dish",
            "Marinara",
            "Hawaiian",
            "Lahma Bi Afeen",
            "M&L Special"});
            this.listBox1.Location = new System.Drawing.Point(318, 36);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(143, 124);
            this.listBox1.TabIndex = 5;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // txtOrder
            // 
            this.txtOrder.Location = new System.Drawing.Point(318, 331);
            this.txtOrder.Multiline = true;
            this.txtOrder.Name = "txtOrder";
            this.txtOrder.Size = new System.Drawing.Size(143, 110);
            this.txtOrder.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(318, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "If you have a dietary restriction:";
            // 
            // cboDietary
            // 
            this.cboDietary.FormattingEnabled = true;
            this.cboDietary.Items.AddRange(new object[] {
            "100 mile",
            "Gluten free",
            "Kosher",
            "Lactose",
            "Non-GMO",
            "Paleo",
            "Vegan",
            "Vegetarian"});
            this.cboDietary.Location = new System.Drawing.Point(318, 193);
            this.cboDietary.Name = "cboDietary";
            this.cboDietary.Size = new System.Drawing.Size(143, 23);
            this.cboDietary.TabIndex = 8;
            this.cboDietary.SelectedIndexChanged += new System.EventHandler(this.cboDietary_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.orderToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(685, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // orderToolStripMenuItem
            // 
            this.orderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pizzaToolStripMenuItem,
            this.resetToolStripMenuItem});
            this.orderToolStripMenuItem.Name = "orderToolStripMenuItem";
            this.orderToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.orderToolStripMenuItem.Text = "Order";
            // 
            // pizzaToolStripMenuItem
            // 
            this.pizzaToolStripMenuItem.Name = "pizzaToolStripMenuItem";
            this.pizzaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pizzaToolStripMenuItem.Text = "Pizza";
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.resetToolStripMenuItem.Text = "Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(318, 231);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(200, 79);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chkJuice);
            this.tabPage1.Controls.Add(this.chkCola);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(192, 51);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Beverage";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // chkJuice
            // 
            this.chkJuice.AutoSize = true;
            this.chkJuice.Location = new System.Drawing.Point(7, 26);
            this.chkJuice.Name = "chkJuice";
            this.chkJuice.Size = new System.Drawing.Size(52, 19);
            this.chkJuice.TabIndex = 1;
            this.chkJuice.Text = "Juice";
            this.chkJuice.UseVisualStyleBackColor = true;
            this.chkJuice.CheckedChanged += new System.EventHandler(this.Beverage_CheckedChanged);
            // 
            // chkCola
            // 
            this.chkCola.AutoSize = true;
            this.chkCola.Location = new System.Drawing.Point(7, 6);
            this.chkCola.Name = "chkCola";
            this.chkCola.Size = new System.Drawing.Size(50, 19);
            this.chkCola.TabIndex = 0;
            this.chkCola.Text = "Cola";
            this.chkCola.UseVisualStyleBackColor = true;
            this.chkCola.CheckedChanged += new System.EventHandler(this.Beverage_CheckedChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chkChocCake);
            this.tabPage2.Controls.Add(this.chkApplePie);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 51);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Dessert";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // chkChocCake
            // 
            this.chkChocCake.AutoSize = true;
            this.chkChocCake.Location = new System.Drawing.Point(7, 26);
            this.chkChocCake.Name = "chkChocCake";
            this.chkChocCake.Size = new System.Drawing.Size(107, 19);
            this.chkChocCake.TabIndex = 1;
            this.chkChocCake.Text = "Chocolate cake";
            this.chkChocCake.UseVisualStyleBackColor = true;
            this.chkChocCake.CheckedChanged += new System.EventHandler(this.Dessert_CheckedChanged);
            // 
            // chkApplePie
            // 
            this.chkApplePie.AutoSize = true;
            this.chkApplePie.Location = new System.Drawing.Point(7, 6);
            this.chkApplePie.Name = "chkApplePie";
            this.chkApplePie.Size = new System.Drawing.Size(76, 19);
            this.chkApplePie.TabIndex = 0;
            this.chkApplePie.Text = "Apple Pie";
            this.chkApplePie.UseVisualStyleBackColor = true;
            this.chkApplePie.CheckedChanged += new System.EventHandler(this.Dessert_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 453);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.cboDietary);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOrder);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "M&L Pizza Palace";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoLargeSize;
        private System.Windows.Forms.RadioButton rdoMediumSize;
        private System.Windows.Forms.RadioButton rdoSmallSize;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbMushroom;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbPepperoni;
        private System.Windows.Forms.CheckBox cbBlackOlive;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtOrder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboDietary;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem orderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pizzaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.CheckBox chkJuice;
        private System.Windows.Forms.CheckBox chkCola;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox chkChocCake;
        private System.Windows.Forms.CheckBox chkApplePie;
    }
}