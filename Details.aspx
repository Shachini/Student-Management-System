<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Details.aspx.cs" Inherits="StudentManagementSystem.Details" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row mt-5 pb-5">
            <div class="col-md-12">
                <h2><strong>Student Details</strong></h2>
                <asp:Button ID="Button1" runat="server" Text="Click here" class="btn custom-learn-button mt-3" OnClick="Button1_Click"/>
                <hr />
            </div>
        </div>

        <!--display student details-->
        <div class="row">
            <div class="col-md-12">
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CssClass="table table-bordered">
                    <Columns>
                        <asp:BoundField HeaderText="Student ID" DataField="StudentId" SortExpression="StudentId" />
                        <asp:BoundField HeaderText="Student Name" DataField="StudentName" SortExpression="StudentName" />
                        <asp:BoundField HeaderText="City" DataField="City" SortExpression="City" />
                        <asp:BoundField HeaderText="Course ID" DataField="CourseId" SortExpression="CourseId" />
                    </Columns>
                </asp:GridView>
            </div>
        </div>
    </div>
  
</asp:Content>
