@ModelType IEnumerable(Of proiect.inrmasina)
@Code
ViewData("Title") = "Index"
End Code

<h2>Index</h2>

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.nrmasina)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.marca)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.model)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.disponibil)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.nrmasina)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.marca)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.model)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.disponibil)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.id }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.id }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.id })
        </td>
    </tr>
Next

</table>
