using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab1
{
    public partial class ValidationAdditional : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed2_Click(object sender, EventArgs e)
        {
            Panel1.Visible = false;
            PanelContacts.Visible = false;
            Panel2.Visible = false;
            Panel3.Visible = false;
            Panel4.Visible = false;
            Panel5.Visible = false;
            Panel6.Visible = false;
            Panel7.Visible = false;
            ((Button)sender).Visible = false;
            CheckBoxBank.Visible = false;
            CheckBoxBank2.Visible = false;

            LabelSuccess.Visible = true;

            ButtonNewCounterParty.Enabled = true;
        }

        protected void CounterParty_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedValue;
            int.TryParse(CounterParty.SelectedValue, out selectedValue);

            if (selectedValue != 2)
            {
                Panel5.Visible = false;
                Panel6.Visible = false;
            }
            else
            {
                Panel5.Visible = true;
                Panel6.Visible = true;
            }
        }

        protected void DropDownListType_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedValue;
            int.TryParse(DropDownListType.SelectedValue, out selectedValue);

            if (selectedValue == 1)
            {
                DropDownListIndividualEntity.Enabled = false;
            }
            else
            {
                DropDownListIndividualEntity.Enabled = true;
            }
        }

        protected void ButtonPostback_Click(object sender, EventArgs e)
        {
            (DropDownListType as IPostBackDataHandler).RaisePostDataChangedEvent();
            (CounterParty as IPostBackDataHandler).RaisePostDataChangedEvent();
        }

        protected void CheckBoxBank_CheckedChanged(object sender, EventArgs e)
        {
            if(CheckBoxBank.Checked)
            {
                Panel2.Visible = true;
            }
            else
            {
                Panel2.Visible = false;
            }
        }

        protected void CheckBoxBank2_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxBank2.Checked)
            {
                Panel3.Visible = true;
            }
            else
            {
                Panel3.Visible = false;
            }
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            TextBoxRegistrationDate.Text = ((Calendar)sender).SelectedDate.ToString();
        }
    }
}