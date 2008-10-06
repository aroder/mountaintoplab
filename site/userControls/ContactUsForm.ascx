<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ContactUsForm.ascx.cs"
    Inherits="lab.userControls.ContactUsForm" %>

<script src="/scripts/jquery.validate.js" type="text/javascript"></script>

<script>
    $.validator.setDefaults({
        submitHandler: function() { alert("submitted!"); }
    });
    $(document).ready(function() {
        $("#ContactUsForm").validate();
    });
</script>

<style>
    label
    {
        /*width: 4em;*/ /*float: left;*/ /*text-align: right;*/ /*margin-right: 0.5em;*/
        display: block;
    }
    .submit
    {
        color: #000;
        background: #ffa20f;
        border: 2px outset #fff;
    }
    input, textarea
    {
        color: #781351;
        background: #fee3ad;
        border: 1px solid #fff;
        position: relative;
    }
    fieldset
    {
        border: 1px solid #fff; /*width: 20em;*/
        padding: 10px;
        width: 220px;
    }
    legend
    {
        color: white;
        background-color: #2B2925;
        padding: 2px 6px;
        border-bottom: 1px solid #F4C833;
    }
    #ContactUsDiv textarea, #ContactUsDiv input.text
    {
        width: 95%;
    }
</style>

<div id="ContactUsDiv">
    <form id="ContactUsForm" method="get" action="mailto:adam.roderick@qortex.com">
    <fieldset>
        <legend>Contact Us</legend>
        <p>
            <label id="ContactUsNameLabel" for="ContactUsName">
                Name</label><input type="text" id="ContactUsName" class="text" /></p>
        <p>
            <label id="ContactUsEmailOrPhoneLabel" for="ContactUsEmailOrPhone">
                Email or Phone</label><input type="text" id="ContactUsEmailOrPhone" class="text" /></p>
        <p>
            <label id="ContactUsCommentsLabel" for="ContactUsComments">
                Comments or Questions</label><textarea id="ContactUsComments" rows="8" wrap="hard"
                    style="overflow: auto;"></textarea></p>
        <p>
            <input class="submit" type="submit" value="  Send  " /></p>
    </fieldset>
    </form>
</div>
