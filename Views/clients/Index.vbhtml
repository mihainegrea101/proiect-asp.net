@ModelType IEnumerable(Of proiect.client)
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
            @Html.DisplayNameFor(Function(model) model.numecump)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.adresa)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.telefon)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.numecump)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.adresa)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.telefon)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.id }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.id }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.id })
        </td>
    </tr>
Next

</table>
