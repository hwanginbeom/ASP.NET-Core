using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

/*
 6.15 | ListBox 컨트롤
6.15.1 소개

리스트박스 컨트롤은 드롭다운 리스트와 기능이 같지만, 드롭다운 리스트를 펼쳐 놓은 모양으로 출력된다. 
또한, Ctrl과 마우스 왼쪽 버튼의 조합으로 여러 항목을 선택할 수 있다.
     
     */

namespace DevStandardControl
{
    public partial class _6__16_FrmListBox : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // 처음 로드할 때만 항목 추가
            if (!Page.IsPostBack)
            {
                // 동적으로 항목 추가
                this.lstHobby.Items.Add("축구");
                this.lstHobby.Items.Add("농구");

                // ListItem 클래스
                ListItem li = new ListItem();
                li.Text = "배구";
                li.Value = "Volleyball";
                lstHobby.Items.Add(li);
            }
        }
        protected void btnPrint_Click(object sender, EventArgs e)
        {
            string strMsg = String.Empty;
            // 리스트박스 항목의 수만큼 반복
            for (int i = 0; i < lstHobby.Items.Count; i++)
            {
                // 선택된 항목이면
                if (lstHobby.Items[i].Selected)
                {
                    // 출력 문자열에 묶음
                    strMsg += lstHobby.Items[i].Text;
                    if (i != lstHobby.Items.Count - 1)
                    {
                        strMsg += ", ";
                    }
                }
            }
            lblDisplay.Text = strMsg;

        }
    }
}