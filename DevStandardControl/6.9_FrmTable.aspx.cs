using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

/*

6.8 | Table 컨트롤
6.8.1 소개

테이블 컨트롤은 동적으로 HTML의 테이블을 생성하고자 할 때 사용하는 서버 컨트롤이다. HTML에서 테이블을 만들 때 사용하는 <table>, <tr>, <td> 태그에 대한 서버 측 표현 방식은 다음과 같다.

• Table 컨트롤: <table> 태그

• TableRow 컬렉션: <tr> 태그

• TableCell 컬렉션: <td> 태그


 */

namespace DevStandardControl
{
    public partial class _6__9_FrmTable : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // [!] 동적으로 1행 1열 테이블 만들기
            // [1] 행(Row)을 하나 추가
            TableRow tr = new TableRow();
            // [2] 열(Column)을 하나 추가
            TableCell td = new TableCell();
            // [3] 내용(Text)을 하나 추가 : 다른 컨트롤에 문자열 추가
            LiteralControl lc = new LiteralControl();
            lc.Text = "안녕";
            // 열에 내용 추가
            td.Controls.Add(lc);
            // 행에 열 추가
            tr.Cells.Add(td);
            // 테이블 컨트롤에 행 추가
            this.ctlMyTable.BorderWidth = 1;
            this.ctlMyTable.Rows.Add(tr);
        }
    }
}