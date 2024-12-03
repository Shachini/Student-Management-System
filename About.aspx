<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="StudentManagementSystem.About" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="./css/style1.css" />
    <script type="text/javascript">
        function scrollToFooter() {
            document.getElementById('footerSection').scrollIntoView({ behavior: 'smooth' });
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="container">
        <div class="row mt-5">
            <div class="col-md-12">
                <h2><strong>About Us</strong></h2>
            </div>
        </div>
        <div class="row">
            <div class="col-md-6">
                <hr />
            </div>
        </div>
        <div class="row">
            <div class="col-md-7 pt-1">
                    <p class="mt-4 custom-hero-para">Welcome to the <b>JLearn Student Management System</b>, a comprehensive solution designed to streamline and simplify the management of student-related information. 
                    Our platform is tailored to meet the needs of educational institutions, ensuring efficient handling of all academic and administrative processes.
                    <br />
                    <br />
                    At the heart of our mission lies a commitment to innovation and excellence in education management. We aim to empower schools, colleges, and universities 
                    with cutting-edge tools that not only save time but also enhance productivity, making the entire management process seamless.</p>
                    <asp:Button ID="Button1" runat="server" Text="Contact Us" class="btn custom-contactus-button mt-3 " BackColor="#F5F5DC" ForeColor="black" OnClientClick="scrollToFooter(); return false;"/>
                </div>
                <div class="col-md-5">
                    <asp:Image ID="Image1" runat="server" src="./images/aboutus.png" class="img-fluid" alt="..."/>
                </div>
        </div>
    </div>
</asp:Content>
