SET IDENTITY_INSERT [dbo].[Hospital] ON
INSERT INTO [dbo].[Hospital] ([HospitalID], [HospitalName], [HospitalBranch], [ContactNumber], [OpeningDate], [Floors]) VALUES (3, N'Waikato Hospital', N'Hamilton', 223887475, N'2020-05-01 08:32:00', 4)
INSERT INTO [dbo].[Hospital] ([HospitalID], [HospitalName], [HospitalBranch], [ContactNumber], [OpeningDate], [Floors]) VALUES (4, N'PGI Hospital', N'Chandigarh', 288776655, N'2020-01-09 08:33:00', 5)
INSERT INTO [dbo].[Hospital] ([HospitalID], [HospitalName], [HospitalBranch], [ContactNumber], [OpeningDate], [Floors]) VALUES (5, N'Aman Hospital', N'Amritsar', 223677878, N'2019-02-09 08:37:00', 3)
INSERT INTO [dbo].[Hospital] ([HospitalID], [HospitalName], [HospitalBranch], [ContactNumber], [OpeningDate], [Floors]) VALUES (6, N'Vijay Hospital', N'Jalandhar', 223878584, N'2018-06-09 08:39:00', 2)
INSERT INTO [dbo].[Hospital] ([HospitalID], [HospitalName], [HospitalBranch], [ContactNumber], [OpeningDate], [Floors]) VALUES (7, N'SGL Hospital', N'Jalandhar', 227889939, N'2019-04-09 08:40:00', 3)
INSERT INTO [dbo].[Hospital] ([HospitalID], [HospitalName], [HospitalBranch], [ContactNumber], [OpeningDate], [Floors]) VALUES (8, N'Rotorua Hospital', N'Rotorua', 226778889, N'2019-07-17 08:41:00', 2)
SET IDENTITY_INSERT [dbo].[Hospital] OFF
INSERT INTO [dbo].[Medicine] ([MedicineName], [Cost], [ExpiryDate], [HospitalID]) VALUES (N'Adderall', 30, N'2022-07-06 09:09:00', 7)
INSERT INTO [dbo].[Medicine] ([MedicineName], [Cost], [ExpiryDate], [HospitalID]) VALUES (N'Amlodipine', 60, N'2022-07-27 09:10:00', 8)
INSERT INTO [dbo].[Medicine] ([MedicineName], [Cost], [ExpiryDate], [HospitalID]) VALUES (N'Ativan', 50, N'2021-09-09 09:07:00', 6)
INSERT INTO [dbo].[Medicine] ([MedicineName], [Cost], [ExpiryDate], [HospitalID]) VALUES (N'Panadol', 80, N'2021-06-05 09:02:00', 4)
INSERT INTO [dbo].[Medicine] ([MedicineName], [Cost], [ExpiryDate], [HospitalID]) VALUES (N'Paracetamol', 20, N'2021-02-20 09:02:00', 3)
INSERT INTO [dbo].[Medicine] ([MedicineName], [Cost], [ExpiryDate], [HospitalID]) VALUES (N'Skin Cream', 40, N'2022-02-09 09:04:00', 5)
SET IDENTITY_INSERT [dbo].[Doctor] ON
INSERT INTO [dbo].[Doctor] ([DoctorID], [DoctorName], [ContactNumber], [JoiningDate], [Salary], [HospitalID]) VALUES (3, N'Karthik', 22388995, N'2019-08-29 08:44:00', 20000, 3)
INSERT INTO [dbo].[Doctor] ([DoctorID], [DoctorName], [ContactNumber], [JoiningDate], [Salary], [HospitalID]) VALUES (4, N'Manisha', 22985895, N'2019-03-21 08:44:00', 25000, 4)
INSERT INTO [dbo].[Doctor] ([DoctorID], [DoctorName], [ContactNumber], [JoiningDate], [Salary], [HospitalID]) VALUES (5, N'Ally', 22848959, N'2019-08-01 08:45:00', 22000, 5)
INSERT INTO [dbo].[Doctor] ([DoctorID], [DoctorName], [ContactNumber], [JoiningDate], [Salary], [HospitalID]) VALUES (6, N'Naira', 22787889, N'2019-10-04 08:46:00', 19000, 6)
INSERT INTO [dbo].[Doctor] ([DoctorID], [DoctorName], [ContactNumber], [JoiningDate], [Salary], [HospitalID]) VALUES (7, N'Dev', 227889589, N'2019-10-30 08:46:00', 34000, 7)
INSERT INTO [dbo].[Doctor] ([DoctorID], [DoctorName], [ContactNumber], [JoiningDate], [Salary], [HospitalID]) VALUES (8, N'Aditya', 22878744, N'2019-07-04 08:47:00', 28000, 8)
SET IDENTITY_INSERT [dbo].[Doctor] OFF
SET IDENTITY_INSERT [dbo].[Patient] ON
INSERT INTO [dbo].[Patient] ([PatientID], [PatientName], [ContactNumber], [AdmitDate], [DischargeDate], [DoctorID]) VALUES (2, N'Arya', 22466656, N'2020-06-11 08:57:00', N'2020-06-29 08:57:00', 3)
INSERT INTO [dbo].[Patient] ([PatientID], [PatientName], [ContactNumber], [AdmitDate], [DischargeDate], [DoctorID]) VALUES (3, N'Navi', 22874889, N'2020-09-09 08:58:00', N'2020-09-18 08:58:00', 4)
INSERT INTO [dbo].[Patient] ([PatientID], [PatientName], [ContactNumber], [AdmitDate], [DischargeDate], [DoctorID]) VALUES (4, N'Ravi', 22678848, N'2020-10-01 08:59:00', N'2020-10-09 08:59:00', 5)
INSERT INTO [dbo].[Patient] ([PatientID], [PatientName], [ContactNumber], [AdmitDate], [DischargeDate], [DoctorID]) VALUES (5, N'Sit', 22499558, N'2020-11-05 09:00:00', N'2020-11-11 09:00:00', 3)
INSERT INTO [dbo].[Patient] ([PatientID], [PatientName], [ContactNumber], [AdmitDate], [DischargeDate], [DoctorID]) VALUES (6, N'Devika', 22883471, N'2020-10-27 09:01:00', N'2020-12-02 09:01:00', 6)
INSERT INTO [dbo].[Patient] ([PatientID], [PatientName], [ContactNumber], [AdmitDate], [DischargeDate], [DoctorID]) VALUES (7, N'Dil', 22848945, N'2020-11-05 09:01:00', N'2020-11-12 09:01:00', 8)
SET IDENTITY_INSERT [dbo].[Patient] OFF
