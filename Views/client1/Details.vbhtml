@ModelType proiect.inrmasina
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>inrmasina</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.nrmasina)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.nrmasina)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.marca)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.marca)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.model)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.model)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.disponibil)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.disponibil)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.id }) |
    @Html.ActionLink("Back to List", "Index")
</p>
