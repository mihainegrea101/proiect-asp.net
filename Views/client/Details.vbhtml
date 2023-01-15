@ModelType proiect.client
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>client</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.numecump)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.numecump)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.adresa)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.adresa)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.telefon)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.telefon)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.id }) |
    @Html.ActionLink("Back to List", "Index")
</p>
