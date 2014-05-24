using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Inventory.Web.UserControl
{
    public partial class PagerControl : System.Web.UI.UserControl
    {
        public event EventHandler OnPageIndexChanging;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// OnPageButtonClick - Event to be captured in the parent page where this pager control is used
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void OnPageButtonClick(object sender, EventArgs e)
        {
            if (OnPageIndexChanging != null)
            {
                OnPageIndexChanging(sender, e);
            }
        }

        /// <summary>
        /// LoadPager - Public method to be called from the parent page to set pager values
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="totalRecords"></param>
        /// <param name="pageSize"></param>
        public void LoadPager(int pageIndex, int totalRecords, int pageSize)
        {
            HidePager();
            if (totalRecords > 0)
            {
                ViewState["TotalRecords"] = totalRecords;
                CreateLinks(totalRecords, pageIndex, pageSize);
            }
        }

        #region Gridview Custom Pager

        /// <summary>
        /// CreateLinks - Method to set appropriate values to the pager buttons on each page index changed
        /// </summary>
        /// <param name="totalRecords"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        private void CreateLinks(int totalRecords, int pageIndex, int pageSize)
        {
            int totalPages = totalRecords / pageSize;
            if (totalRecords % pageSize > 0)
            {
                totalPages += 1;
            }

            if (pageIndex < 10)
            {
                for (int z = 0; z < totalPages; z++)
                {
                    int pageNo = z + 1;

                    if (pageNo <= 10)
                    {
                        LinkPrev.Visible = false;
                        LinkFirst.Visible = false;

                        if ((pageNo - 1) != pageIndex)
                            PopulateLink(pageNo, 0, "inactive");
                        else
                            PopulateLink(pageNo, 0, "active");
                    }
                    else
                    {
                        if (totalPages > 10)
                        {
                            SetEndLinks(pageNo, totalPages);
                        }
                        break;
                    }
                }
            }

            else
            {
                int range = (pageIndex / 10);
                LinkFirst.Visible = true;
                LinkFirst.CommandArgument = "0";
                LinkPrev.Visible = true;
                LinkPrev.CommandArgument = ((range * 10) - 1).ToString();

                for (int z = (range * 10); z < totalPages; z++)
                {
                    int pageNo = z + 1;
                    if (pageNo <= ((range * 10) + 10))
                    {
                        if ((pageNo - 1) != pageIndex)
                            PopulateLink(pageNo, range, "inactive");
                        else
                            PopulateLink(pageNo, range, "active");
                    }
                    else
                    {
                        if (pageIndex < (totalPages - 1))
                        {
                            SetEndLinks(pageNo, totalPages);
                        }
                        break;
                    }

                }
            }
        }

        /// <summary>
        /// PopulateLink - Method to find the Linkbutton and set its properties
        /// </summary>
        /// <param name="pageNo"></param>
        /// <param name="range"></param>
        /// <param name="cssclass"></param>
        private void PopulateLink(int pageNo, int range, string cssclass)
        {
            //To find the control even if it is placed on any container. (Change the root control id)
            LinkButton Lbtn = FindControlRecursive(this, "Link" + (pageNo - (range * 10)).ToString()) as LinkButton;
            if (Lbtn != null)
            {
                Lbtn.Text = pageNo.ToString();
                Lbtn.CommandArgument = (pageNo - 1).ToString();
                Lbtn.Visible = true;
                Lbtn.CssClass = cssclass;
            }
        }

        private void SetEndLinks(int pageNo, int totalPages)
        {
            LinkNext.Visible = true;
            LinkNext.CommandArgument = (pageNo - 1).ToString();
            LinkLast.Visible = true;
            LinkLast.CommandArgument = (totalPages - 1).ToString();
        }

        /// <summary>
        /// Link_Click - Event raised on the click of linkbuttons of Pager Control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Link_Click(object sender, EventArgs e)
        {
            OnPageButtonClick(sender, e);
        }


        /// <summary>
        /// FindControlRecursive - Method to find the linkbuttons embedded in the parent control
        /// </summary>
        /// <param name="root"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        private Control FindControlRecursive(Control root, string id)
        {
            if (root.ID == id)
            {
                return root;
            }
            foreach (Control c in root.Controls)
            {
                Control t = FindControlRecursive(c, id);
                if (t != null)
                {
                    return t;
                }
            }
            return null;
        }


        /// <summary>
        /// HidePager - Method to hide the pager buttons
        /// </summary>
        private void HidePager()
        {
            LinkFirst.Visible = false;
            LinkPrev.Visible = false;
            LinkNext.Visible = false;
            LinkLast.Visible = false;

            for (int i = 1; i <= 10; i++)
                (FindControlRecursive(this, "Link" + i.ToString()) as LinkButton).Visible = false;
        }

        #endregion
    }
}