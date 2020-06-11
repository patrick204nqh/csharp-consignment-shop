namespace ConsignmentShop
{
    partial class ConsignmentShop
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
            this.headerText = new System.Windows.Forms.Label();
            this.itemsListbox = new System.Windows.Forms.ListBox();
            this.itemsListboxLabel = new System.Windows.Forms.Label();
            this.addToCart = new System.Windows.Forms.Button();
            this.shoppingCartListboxLabel = new System.Windows.Forms.Label();
            this.shoppingCartListbox = new System.Windows.Forms.ListBox();
            this.makePurchase = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headerText
            // 
            this.headerText.AutoSize = true;
            this.headerText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerText.Location = new System.Drawing.Point(11, 11);
            this.headerText.Name = "headerText";
            this.headerText.Size = new System.Drawing.Size(188, 24);
            this.headerText.TabIndex = 0;
            this.headerText.Text = "Consignment Shop";
            this.headerText.Click += new System.EventHandler(this.headerText_Click);
            // 
            // itemsListbox
            // 
            this.itemsListbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemsListbox.FormattingEnabled = true;
            this.itemsListbox.ItemHeight = 16;
            this.itemsListbox.Location = new System.Drawing.Point(15, 74);
            this.itemsListbox.Margin = new System.Windows.Forms.Padding(2);
            this.itemsListbox.Name = "itemsListbox";
            this.itemsListbox.Size = new System.Drawing.Size(184, 132);
            this.itemsListbox.TabIndex = 1;
            this.itemsListbox.SelectedIndexChanged += new System.EventHandler(this.ItemsListbox_SelectedIndexChanged);
            // 
            // itemsListboxLabel
            // 
            this.itemsListboxLabel.AutoSize = true;
            this.itemsListboxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemsListboxLabel.Location = new System.Drawing.Point(12, 56);
            this.itemsListboxLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.itemsListboxLabel.Name = "itemsListboxLabel";
            this.itemsListboxLabel.Size = new System.Drawing.Size(86, 16);
            this.itemsListboxLabel.TabIndex = 2;
            this.itemsListboxLabel.Text = "Store Items";
            this.itemsListboxLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // addToCart
            // 
            this.addToCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addToCart.Location = new System.Drawing.Point(203, 116);
            this.addToCart.Margin = new System.Windows.Forms.Padding(2);
            this.addToCart.Name = "addToCart";
            this.addToCart.Size = new System.Drawing.Size(105, 32);
            this.addToCart.TabIndex = 3;
            this.addToCart.Text = "Add To Cart  >";
            this.addToCart.UseVisualStyleBackColor = true;
            this.addToCart.Click += new System.EventHandler(this.addToCart_Click);
            // 
            // shoppingCartListboxLabel
            // 
            this.shoppingCartListboxLabel.AutoSize = true;
            this.shoppingCartListboxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shoppingCartListboxLabel.Location = new System.Drawing.Point(309, 56);
            this.shoppingCartListboxLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.shoppingCartListboxLabel.Name = "shoppingCartListboxLabel";
            this.shoppingCartListboxLabel.Size = new System.Drawing.Size(106, 16);
            this.shoppingCartListboxLabel.TabIndex = 5;
            this.shoppingCartListboxLabel.Text = "Shopping Cart";
            // 
            // shoppingCartListbox
            // 
            this.shoppingCartListbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shoppingCartListbox.FormattingEnabled = true;
            this.shoppingCartListbox.ItemHeight = 16;
            this.shoppingCartListbox.Location = new System.Drawing.Point(312, 74);
            this.shoppingCartListbox.Margin = new System.Windows.Forms.Padding(2);
            this.shoppingCartListbox.Name = "shoppingCartListbox";
            this.shoppingCartListbox.Size = new System.Drawing.Size(184, 132);
            this.shoppingCartListbox.TabIndex = 4;
            // 
            // makePurchase
            // 
            this.makePurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.makePurchase.Location = new System.Drawing.Point(391, 210);
            this.makePurchase.Margin = new System.Windows.Forms.Padding(2);
            this.makePurchase.Name = "makePurchase";
            this.makePurchase.Size = new System.Drawing.Size(105, 32);
            this.makePurchase.TabIndex = 6;
            this.makePurchase.Text = "Purchase";
            this.makePurchase.UseVisualStyleBackColor = true;
            this.makePurchase.Click += new System.EventHandler(this.makePurchase_Click);
            // 
            // ConsignmentShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 319);
            this.Controls.Add(this.makePurchase);
            this.Controls.Add(this.shoppingCartListboxLabel);
            this.Controls.Add(this.shoppingCartListbox);
            this.Controls.Add(this.addToCart);
            this.Controls.Add(this.itemsListboxLabel);
            this.Controls.Add(this.itemsListbox);
            this.Controls.Add(this.headerText);
            this.Enabled = false;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ConsignmentShop";
            this.Text = "Consignment Shop";
            this.Load += new System.EventHandler(this.ConsignmentShop_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerText;
        private System.Windows.Forms.ListBox itemsListbox;
        private System.Windows.Forms.Label itemsListboxLabel;
        private System.Windows.Forms.Button addToCart;
        private System.Windows.Forms.Label shoppingCartListboxLabel;
        private System.Windows.Forms.ListBox shoppingCartListbox;
        private System.Windows.Forms.Button makePurchase;
    }
}

