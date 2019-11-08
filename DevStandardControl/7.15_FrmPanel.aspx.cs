using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

/*
 패널 컨트롤은 HTML의 <div>와 같이 HTML 및 웹 폼 구성 요소를 담는 컨테이너 역할을 하는 컨트롤이다.

• ASP.NET의 소스 부분

<asp:Panel>

• 웹 브라우저 출력 부분

<div>

특정 부분을 스크롤바로 그룹화하거나 레이블로 그룹화하는 방법과 특정 영역에서 엔터키를 눌렀을 때 특정 버튼이 클릭되는 기능을 구현하는 방법을 살펴보자.


    패널 컨트롤의 주요 구성 요소는 다음 표와 같다.

멤버

이름

설명



System.Web.UI.WebControls.Panel 클래스

속성

Visible - 해당 패널을 보일지 안 보일지 결정

ScrollBars - 패널에 스크롤바를 보일지 안 보일지 결정

BackImageUrl - 배경 이미지 경로

Wrap - 줄 바꿈 지정 설정

HorizontalAlign - 패널 안에 있는 문자열의 정렬 설정

GroupingText - 패널 상단에 텍스트 출력

DefaultButton - 패널 컨트롤에서 엔터키를 눌렀을 때 어떤 버튼을 자동으로 클릭할 것인지를 해당 버튼의 ID 속성으로 지정
     */

namespace DevStandardControl
{
    public partial class _7__15_FrmPanel : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                // 텍스트박스에 포커스 두기
                Page.SetFocus(txtMessage);
            }

            // 로드될 때 첫 번째 패널만 보이기
            this.pnlFirst.Visible = true;
            this.pnlSecond.Visible = false;
            // 첫 번째 패널 -> 두 번째 버튼 보이기
            btnShowPanel1.Visible = false;
            btnShowPanel2.Visible = true;
        }
        protected void btnShowPanel1_Click(object sender, EventArgs e)
        {
            this.pnlFirst.Visible = true;
            this.pnlSecond.Visible = false;
            btnShowPanel1.Visible = false;
            btnShowPanel2.Visible = true;
            // 텍스트박스에 포커스
            SetFocus(txtMessage);
            pnlCommand.DefaultButton = "btnShowPanel2";
        }
        protected void btnShowPanel2_Click(object sender, EventArgs e)
        {
            this.pnlFirst.Visible = false;
            this.pnlSecond.Visible = true;
            btnShowPanel1.Visible = true;
            btnShowPanel2.Visible = false;
            // 텍스트박스에 포커스
            SetFocus(txtMessage);
            pnlCommand.DefaultButton = "btnShowPanel1";
        }
    }
}
