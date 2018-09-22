using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AutoAddicts.Models;
using AutoAddicts.Logic;


namespace AutoAddicts.Admin
{
    public partial class AdminPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string productAction = Request.QueryString["ProductAction"];
            if (productAction == "add")
            {
                LabelAddStatus.Text = "Product added!";
            }

            if (productAction == "remove")
            {
                LabelRemoveStatus.Text = "Product removed!";
            }

        }

        protected void AddProductButton_Click(object sender, EventArgs e)
        {
            Boolean fileOK = false;
            String path = Server.MapPath("~/Catalog/Images/");
            if (ProductImage.HasFile)
            {
                String fileExtension = System.IO.Path.GetExtension(ProductImage.FileName).ToLower();
                String[] allowedExtensions = { ".gif", ".png", ".jpeg", ".jpg" };
                for (int i = 0; i < allowedExtensions.Length; i++)
                {
                    if (fileExtension == allowedExtensions[i])
                    {
                        fileOK = true;
                    }
                }
            }

            if (fileOK)
            {
                try
                {
                    // Save to Images folder.
                    ProductImage.PostedFile.SaveAs(path + ProductImage.FileName);
                    // Save to Images/Thumbs folder.
                    ProductImage.PostedFile.SaveAs(path + "Thumbs/" + ProductImage.FileName);
                }
                catch (Exception ex)
                {
                    LabelAddStatus.Text = ex.Message;
                }

                // Add product data to DB.
                AddProducts products = new AddProducts();
                bool addSuccess = products.AddProduct(AddProductName.Text, AddProductDescription.Text,
                    AddProductPrice.Text, DropDownAddCategory.SelectedValue, ProductImage.FileName, AddWarranty.Text);
                if (addSuccess)
                {
                    // Reload the page.
                    string pageUrl = Request.Url.AbsoluteUri.Substring(0, Request.Url.AbsoluteUri.Count() - Request.Url.Query.Count());
                    Response.Redirect(pageUrl + "?ProductAction=add");
                }
                else
                {
                    LabelAddStatus.Text = "Unable to add new product to database.";
                }
            }
            else
            {
                LabelAddStatus.Text = "Unable to accept file type.";
            }
        }

        public IQueryable GetCategories()
        {
            var _db = new AutoAddicts.Models.ProductContext();
            IQueryable query = _db.Categories;
            return query;
        }

        public IQueryable GetProducts()
        {
            var _db = new AutoAddicts.Models.ProductContext();
            IQueryable query = _db.Products;
            return query;
        }

        protected void RemoveProductButton_Click(object sender, EventArgs e)
        {
            using (var _db = new AutoAddicts.Models.ProductContext())
            {
                int productId = Convert.ToInt16(DropDownRemoveProduct.SelectedValue);
                var myItem = (from c in _db.Products where c.ProductID == productId select c).FirstOrDefault();
                if (myItem != null)
                {
                    _db.Products.Remove(myItem);
                    _db.SaveChanges();

                    // Reload the page.
                    string pageUrl = Request.Url.AbsoluteUri.Substring(0, Request.Url.AbsoluteUri.Count() - Request.Url.Query.Count());
                    Response.Redirect(pageUrl + "?ProductAction=remove");
                }
                else
                {
                    LabelRemoveStatus.Text = "Unable to locate product.";
                }
            }
        }

        protected void ModifyProductButton_Click(object sender, EventArgs e)
        {
            using (var _db = new AutoAddicts.Models.ProductContext())
            {
                string ID = cmbCategory.SelectedValue;
                string name = txtName.Text;
                string desc = txtDesc.Text;
                string warranty = txtWarranty.Text;
                string price = txtPrice.Text;

                string message = "UPDATE dbo.Products SET ProductName = '" + name + "' , Description = '" + desc + "' , UnitPrice = '" + price + "' , Warranty = '" + warranty + "' WHERE ProductID = " + ID;
                 _db.Database.ExecuteSqlCommand(message);
            }
        }


        /*protected void cmbCategory_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            using (var _db = new AutoAddicts.Models.ProductContext())
            {
                string ID = cmbCategory.SelectedValue;

                txtName.Text = _db.Database.SqlQuery<string>("SELECT ProductName FROM dbo.Products WHERE ProductID = @ID", ID).ToString();
                txtDesc.Text = _db.Database.SqlQuery<string>("SELECT Description FROM dbo.Products WHERE ProductID = @ID", ID).ToString();
                txtPrice.Text = _db.Database.SqlQuery<string>("SELECT Price FROM dbo.Products WHERE ProductID = @ID", ID).ToString();
                txtWarranty.Text = _db.Database.SqlQuery<string>("SELECT Warranty FROM dbo.Products WHERE ProductID = @ID", ID).ToString();
                txtName.Attributes.Add("placeholder", "CHANGED"); 

                

            }

        }*/

    }
}