Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports proiect

Namespace Controllers
    Public Class masinaController
        Inherits System.Web.Mvc.Controller

        Private db As New supercarEntities

        ' GET: masina
        Function Index() As ActionResult
            Return View(db.inrmasina.ToList())
        End Function

        ' GET: masina/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim inrmasina As inrmasina = db.inrmasina.Find(id)
            If IsNothing(inrmasina) Then
                Return HttpNotFound()
            End If
            Return View(inrmasina)
        End Function

        ' GET: masina/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: masina/Create
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="id,nrmasina,marca,model,disponibil")> ByVal inrmasina As inrmasina) As ActionResult
            If ModelState.IsValid Then
                db.inrmasina.Add(inrmasina)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(inrmasina)
        End Function

        ' GET: masina/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim inrmasina As inrmasina = db.inrmasina.Find(id)
            If IsNothing(inrmasina) Then
                Return HttpNotFound()
            End If
            Return View(inrmasina)
        End Function

        ' POST: masina/Edit/5
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="id,nrmasina,marca,model,disponibil")> ByVal inrmasina As inrmasina) As ActionResult
            If ModelState.IsValid Then
                db.Entry(inrmasina).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(inrmasina)
        End Function

        ' GET: masina/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim inrmasina As inrmasina = db.inrmasina.Find(id)
            If IsNothing(inrmasina) Then
                Return HttpNotFound()
            End If
            Return View(inrmasina)
        End Function

        ' POST: masina/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim inrmasina As inrmasina = db.inrmasina.Find(id)
            db.inrmasina.Remove(inrmasina)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub
    End Class
End Namespace
