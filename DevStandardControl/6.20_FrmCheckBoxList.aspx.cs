using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


/*
6.20 | 실습_ CheckBoxList 컨트롤을 사용해 여러 개의 체크박스 만들기
6.20.1 소개

체크박스리스트 컨트롤을 사용해 취미 정보를 선택하는 예제를 만들어 보자. 
체크박스를 따로 만드는 체크박스 컨트롤과 달리 체크박스리스트 컨트롤은 컨트롤 하나에
ListItem을 여러 개 두어서 하나의 이름으로 관리하는 구조다.
     */

namespace DevStandardControl
{
    public partial class _6__20_FrmCheckBoxList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnOK_Click(object sender, EventArgs e)
        {
            string strMsg = "당신의 취미는<br/>";
            for (int i = 0; i < lstHobby.Items.Count; i++)
            {
                if (lstHobby.Items[i].Selected)
                {
                    strMsg += lstHobby.Items[i].Text + "<br/>";
                }
            }
            lblDisplay.Text = strMsg;
        }

    }
}