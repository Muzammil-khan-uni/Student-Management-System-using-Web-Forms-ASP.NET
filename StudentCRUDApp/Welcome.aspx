<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Welcome.aspx.cs" Inherits="StudentCRUDApp.Welcome" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Welcome</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/css/bootstrap.min.css" rel="stylesheet" />
    <link href="WelcomeStyles.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="welcome-container">
            <h1 class="display-4">Welcome to Student Management System</h1>
            <p class="lead">Effortlessly manage student information with our user-friendly interface.</p>
            <asp:Button ID="BtnContinue" runat="server" Text="Continue" CssClass="btn btn-primary btn-lg" OnClick="BtnContinue_Click" />
        </div>
    </form>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/js/bootstrap.bundle.min.js"></script>
</body>
</html>
