<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Start.aspx.cs" Inherits="RSVP.Start" MasterPageFile="~/Site.master"%>
 <asp:Content ID="MainContent" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <link rel="stylesheet" type="text/css" href="Styles.css" />       
     <div class="rek">
            <h1>Приглашение на семинар</h1>
                 <asp:ScriptManager ID="ScriptManager1" runat="server"/>
            <p>Вы приглашены на наш семинар</p>
            <p>Подтвердите свое согласие, пройдя регистрацию</p>
            </div>
            <div class="info">
                Семинар состоится 1 января 2022 года в 7.30
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>
                        <asp:Timer runat="server" Interval="1000"/>
                        <%DateTime dataseminar = new DateTime(2022,1,1,7,30,0);
                            DateTime dnow = DateTime.Now;
                            int rd = (dataseminar - dnow).Days;
                            int rm = (dataseminar - dnow).Minutes;
                            int rsec = (dataseminar - dnow).Seconds;%>
                        <h3>До семинара осталось <%=rd.ToString()%> дн., <%=rm.ToString()%> мин. и <%=rsec.ToString()%> с.</h3>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </div>
 </asp:Content>

       