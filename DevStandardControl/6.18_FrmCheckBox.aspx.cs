using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

/*
 
6.17.2 CheckBox 컨트롤의 주요 구성 요소

체크박스 컨트롤의 주요 구성 요소는 다음 표와 같다.


CheckBox - System.Web.UI.WebControls.CheckBox 클래스

속성

Checked - 체크박스가 선택되면 true, 그렇지 않으면 false 값 반환

AutoPostBack - 체크박스가 선택되거나 해제되는 순간에 자동으로 서버 측으로 포스트백 (다시 게시)할 것인지 결정. true로 설정하면 매번 포스트백시킨다.

Text - 체크박스에 쓰여질 문구

TextAlign - Text 속성의 위치(Right | Left)

이벤트

CheckedChanged - 체크박스의 값이 변경될 때 발생
     
     */

namespace DevStandardControl
{
    public partial class _6__18_FrmCheckBox : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCheck_Click(object sender, EventArgs e)
        {
            string strMsg = "선택한 값:<br/>";
            if (this.chkCSharp.Checked)
            {
                strMsg += chkCSharp.Text + "<br/>";
            }
            if (this.chkAspNet.Checked)
            {
                strMsg += chkAspNet.Text + "<br/>";
            }
            lblDisplay.Text = strMsg;
        }
    }
}