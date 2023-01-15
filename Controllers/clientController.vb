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
    Public Class clientController
        Inherits System.Web.Mvc.Controller

        Private db As New supercarEntities

        ' GET: client
        Function Index() As ActionResult
            Return View(db.client.ToList())
        End Function

        ' GET: client/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim client As client = db.client.Find(id)
            If IsNothing(client) Then
                Return HttpNotFound()
            End If
            Return View(client)
        End Function

        ' GET: client/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: client/Create
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="id,numecump,adresa,telefon")> ByVal client As client) As ActionResult
            If ModelState.IsValid Then
                db.client.Add(client)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(client)
        End Function

        ' GET: client/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim client As client = db.client.Find(id)
            If IsNothing(client) Then
                Return HttpNotFound()
            End If
            Return View(client)
        End Function

        ' POST: client/Edit/5
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="id,numecump,adresa,telefon")> ByVal client As client) As ActionResult
            If ModelState.IsValid Then
                db.Entry(client).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(client)
        End Function

        ' GET: client/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim client As client = db.client.Find(id)
            If IsNothing(client) Then
                Return HttpNotFound()
            End If
            Return View(client)
        End Function

        ' POST: client/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim client As client = db.client.Find(id)
            db.client.Remove(client)
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
