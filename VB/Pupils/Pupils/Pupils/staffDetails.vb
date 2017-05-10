Imports System.IO

Public Class staffDetails

    Private Structure Staff
        Public StaffId As String
        Public FirstName As String
        Public Surname As String
        Public HomeAdd As String                  'Creating the structure that will hold the  data.
        Public EmergencyNo As String
        Public Department As String
        Public DOB As Date
    End Structure


    Private Sub staffDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Dir$("Staff.txt") = "" Then
            Dim sw As New StreamWriter("Staff.txt", True)    'This makes sure there is actually a textfile to enter/read data. If not, it creates a new blank one.
            sw.WriteLine("")
            sw.Close()
            MsgBox("A new file has been created", vbExclamation, "Warning!") 'telling the user about the new file creation
        End If

        Dim StaffData() As String = File.ReadAllLines("Staff.txt") 'retriving the data inside the text file Staff.txt
        For i = 0 To UBound(StaffData)
            If Trim(Mid(StaffData(i), 1, 50)) = "" Then 'if the record is empty no calculation is proformed
            Else


                If Trim(Mid(StaffData(i), 1, 50)) >= txtStaffID.Text Then 'if a client id inside the text file is larger than the default or any other client ids in the text file a new highest client id will be set e.g. if the highest client id in the text file is 10003 then this code will set the next client id as the same but incremented by 1
                    txtStaffID.Text = Trim(Mid(StaffData(i), 1, 50)) + 1
                End If
            End If
        Next i



    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click


        If txtDepartment.Text.Replace(" ", "") = "" Then
            MsgBox("Please enter a Department.")
        End If
        If txtFirstName.Text.Replace(" ", "") = "" Then
            MsgBox("Please enter a First Name.")
        End If
        If txtEmergencyNo.Text.Replace(" ", "") = "" Then
            MsgBox("Please enter a Emergency Telephone Number.")
        End If
        If txtHomeAdd.Text.Replace(" ", "") = "" Then
            MsgBox("Please enter a Home Address.")
        End If
        If txtSurname.Text.Replace(" ", "") = "" Then 'checks if there is data in the textbox required.  - presence check
            MsgBox("Please enter a Surname.")
        End If

        If dtpDOB.Value.Year > Date.Now.Year Then 'check to make sure the user hasn't entered a birth date in the future. -range check
            MsgBox("You have entered a date of birth in the furture. Please enter a valid Date of Birth.")
        End If

        If IsNumeric(txtEmergencyNo.Text.Replace(" ", "")) = False Then 'checks that the user has entered a number and not text or other symbols. -data type check
            MsgBox("The emergency telephone number you have entered contains forign characters. Please enter a valid Phone Number.")
        End If

        If txtFirstName.Text.Length > 50 Then 'checks that the user has not entered a field that is too long to be stored in the text file - length check
            MsgBox("First name entered is too long. Please enter a valid First Name.")
        End If
        If txtSurname.Text.Length > 50 Then
            MsgBox("Surname entered is too long. Please enter a valid Surname.")
        End If
        If txtHomeAdd.Text.Length > 50 Then
            MsgBox("Home Address entered is too long. Please enter a valid Home Address.")
        End If
        If txtDepartment.Text.Length > 50 Then
            MsgBox("Department entered is too long. Please enter a valid Department.")
        End If

        If txtEmergencyNo.Text.Replace(" ", "").Length > 11 Then
            MsgBox("The Phone Number you have entered is too long. Please enter a valid Phone Number.")
        End If

        If txtEmergencyNo.Text.Replace(" ", "").Length < 11 Then
            MsgBox("The Phone Number you have entered is too short. Please enter a valid Phone Number.")
        End If






        Dim CountGot As Integer
        Dim StaffDatas() As String = File.ReadAllLines("Staff.txt") 'retrives the records inside the text file.
        For i = 0 To UBound(StaffDatas)

            CountGot = 0
            If Trim(Mid(StaffDatas(i), 51, 50)) = txtFirstName.Text Then CountGot = CountGot + 1
            If Trim(Mid(StaffDatas(i), 101, 50)) = txtSurname.Text Then CountGot = CountGot + 1
            If Trim(Mid(StaffDatas(i), 151, 50)) = txtHomeAdd.Text Then CountGot = CountGot + 1
            If Trim(Mid(StaffDatas(i), 201, 50)) = txtEmergencyNo.Text Then CountGot = CountGot + 1
            If Trim(Mid(StaffDatas(i), 251, 50)) = txtDepartment.Text Then CountGot = CountGot + 1
            If Trim(Mid(StaffDatas(i), 301, 50)) = dtpDOB.Value Then CountGot = CountGot + 1 'makes sure there are no duplicate records by checking the record attempting to be entered against current records in the text file
            If CountGot = 6 Then
                MsgBox("Record is already on the system.") 'outputting to the user if there is already an identical record in the text file
            End If
        Next i





        Dim StaffData As New Staff
        Dim sw As New System.IO.StreamWriter("Staff.txt", True)
        StaffData.StaffId = LSet(txtStaffID.Text, 50)
        StaffData.FirstName = LSet(txtFirstName.Text, 50)
        StaffData.Surname = LSet(txtSurname.Text, 50)
        StaffData.HomeAdd = LSet(txtHomeAdd.Text, 50)                      'Filling the structure with data.
        StaffData.EmergencyNo = LSet(txtEmergencyNo.Text, 50)
        StaffData.Department = LSet(txtDepartment.Text, 50)
        StaffData.DOB = LSet(dtpDOB.Value, 50)

        sw.WriteLine(StaffData.StaffId & StaffData.FirstName & StaffData.Surname & StaffData.HomeAdd & StaffData.EmergencyNo) 'using the structure to output the data into a serial text file.
        sw.Close()                                                                  'Always need to close afterwards
        MsgBox("File Saved!") 'notifying the user that the record was successfully added to the text file.

        For i = 0 To UBound(StaffDatas)
            If Trim(Mid(StaffDatas(i), 1, 50)) = "" Then 'if the record is empty no calculation is proformed
            Else


                If Trim(Mid(StaffDatas(i), 1, 50)) >= txtStaffID.Text Then 'if a client id inside the text file is larger than the default or any other client ids in the text file a new highest client id will be set e.g. if the highest client id in the text file is 10003 then this code will set the next client id as the same but incremented by 1
                    txtStaffID.Text = Trim(Mid(StaffDatas(i), 1, 50)) + 1 'incrementing the client id
                End If
            End If
        Next i

    End Sub


    Private Sub btnRetreive_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRetreive.Click

        txtDepartment.Enabled = False
        txtEmergencyNo.Enabled = False
        txtFirstName.Enabled = False
        txtSurname.Enabled = False
        txtHomeAdd.Enabled = False
        dtpDOB.Enabled = False
        btnBack.Visible = True
        cmbStaffID.Visible = True
        btnRetreive.Visible = False 'preparing for a view where the user cannot edit data in the textboxes or date time pickers


        Dim StaffData() As String = File.ReadAllLines("Staff.txt") 'retrives the records inside the text file.
        For i = 0 To UBound(StaffData)
            cmbStaffID.Items.Add(Trim(Mid(StaffData(i), 1, 50))) 'adding all the clientids assosiated with records that are in the textbox to a combobox.
        Next i





    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click

        txtDepartment.Enabled = True
        txtEmergencyNo.Enabled = True
        txtFirstName.Enabled = True
        txtSurname.Enabled = True
        txtHomeAdd.Enabled = True
        dtpDOB.Enabled = True
        btnBack.Visible = False
        cmbStaffID.Visible = False
        btnRetreive.Visible = True

        Dim StaffDatas() As String = File.ReadAllLines("Staff.txt") 'retrives the records inside the text file.
        For i = 0 To UBound(StaffDatas)
            If Trim(Mid(StaffDatas(i), 1, 50)) = "" Then 'if the record is empty no calculation is proformed
            Else


                If Trim(Mid(StaffDatas(i), 1, 50)) >= txtStaffID.Text Then 'if a client id inside the text file is larger than the default or any other client ids in the text file a new highest client id will be set e.g. if the highest client id in the text file is 10003 then this code will set the next client id as the same but incremented by 1
                    txtStaffID.Text = Trim(Mid(StaffDatas(i), 1, 50)) + 1 'incrementing the client id by 1
                End If
            End If
        Next i

    End Sub

    Private Sub cmbStaffID_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbStaffID.SelectedIndexChanged




        Dim StaffData() As String = File.ReadAllLines("Staff.txt") 'retrives the records inside the text file.
        For i = 0 To UBound(StaffData)
            If Trim(Mid(StaffData(i), 1, 50)) = "" Then 'if the record is empty no calculation is proformed
            Else


                If Trim(Mid(StaffData(i), 1, 50)) = cmbStaffID.Text Then 'if the clientif of the record in question is the same as the search client id then that record is displayed in textboxes and date time pivkers.
                    txtStaffID.Text = Trim(Mid(StaffData(i), 1, 50))
                    txtFirstName.Text = Trim(Mid(StaffData(i), 51, 50))
                    txtSurname.Text = Trim(Mid(StaffData(i), 101, 50))
                    txtHomeAdd.Text = Trim(Mid(StaffData(i), 151, 50))
                    txtEmergencyNo.Text = Trim(Mid(StaffData(i), 201, 50))
                    txtDepartment.Text = Trim(Mid(StaffData(i), 251, 50))
                    dtpDOB.Text = Trim(Mid(StaffData(i), 301, 50))
                End If
            End If
        Next i

    End Sub
End Class