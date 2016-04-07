
INSERT [dbo].[Category] ([ID], [Name], [Description]) VALUES (N'8b0d80cd-f830-4173-af4d-01ab7a46e74a', N'TEST1', N'Description Test 1')
GO
INSERT [dbo].[Category] ([ID], [Name], [Description]) VALUES (N'1f896b1e-7e64-4c54-aa80-2b8ed63a3a73', N'TEST3', N'Description Test 3')
GO
INSERT [dbo].[Category] ([ID], [Name], [Description]) VALUES (N'168570d6-3dfe-4abe-a84c-df1b4158c12f', N'TEST2', N'Description Test 2')
GO
INSERT [dbo].[Questions] ([ID], [UserID], [CategoryID], [Title], [Description], [Added], [Modified]) VALUES (N'25c0f54b-84d9-438d-a2dd-44855d2f9375', N'78eb4232-23fc-41e2-a76e-ab08acc99e39', N'168570d6-3dfe-4abe-a84c-df1b4158c12f', N'Question 3', N'Question 2 is still not about java :(', CAST(N'2016-04-07T10:42:53.500' AS DateTime), CAST(N'2016-04-07T10:42:53.500' AS DateTime))
GO
INSERT [dbo].[Questions] ([ID], [UserID], [CategoryID], [Title], [Description], [Added], [Modified]) VALUES (N'5b569516-c3ee-423e-9990-69e3f5a674ca', N'78eb4232-23fc-41e2-a76e-ab08acc99e39', N'1f896b1e-7e64-4c54-aa80-2b8ed63a3a73', N'Question 2', N'Question 2 is not about java :(', CAST(N'2016-04-07T10:42:29.093' AS DateTime), CAST(N'2016-04-07T10:42:29.093' AS DateTime))
GO
INSERT [dbo].[Questions] ([ID], [UserID], [CategoryID], [Title], [Description], [Added], [Modified]) VALUES (N'236efe44-d9e3-456a-9f5a-e98db457a50a', N'78eb4232-23fc-41e2-a76e-ab08acc99e39', N'8b0d80cd-f830-4173-af4d-01ab7a46e74a', N'Question 1', N'Question 1 is not about java :(', CAST(N'2016-04-07T10:41:06.743' AS DateTime), CAST(N'2016-04-07T10:41:06.743' AS DateTime))
GO
INSERT [dbo].[Tags] ([ID], [Name], [Description]) VALUES (N'd6178ce7-1d7c-4ed9-ab68-2684567b74cb', N'TAG2', N'Description tag 3')
GO
INSERT [dbo].[Tags] ([ID], [Name], [Description]) VALUES (N'8c9eecfe-5cab-40a5-b846-841445a1315e', N'TAG1', N'Description tag 1')
GO
INSERT [dbo].[Tags] ([ID], [Name], [Description]) VALUES (N'0908d891-e526-44e7-a449-ec46d47e2050', N'TAG3', N'Description tag 3')
GO
INSERT [dbo].[QuestionTags] ([QuestionID], [TagID]) VALUES (N'25c0f54b-84d9-438d-a2dd-44855d2f9375', N'd6178ce7-1d7c-4ed9-ab68-2684567b74cb')
GO
INSERT [dbo].[QuestionTags] ([QuestionID], [TagID]) VALUES (N'5b569516-c3ee-423e-9990-69e3f5a674ca', N'd6178ce7-1d7c-4ed9-ab68-2684567b74cb')
GO
INSERT [dbo].[QuestionTags] ([QuestionID], [TagID]) VALUES (N'5b569516-c3ee-423e-9990-69e3f5a674ca', N'8c9eecfe-5cab-40a5-b846-841445a1315e')
GO
INSERT [dbo].[QuestionTags] ([QuestionID], [TagID]) VALUES (N'5b569516-c3ee-423e-9990-69e3f5a674ca', N'0908d891-e526-44e7-a449-ec46d47e2050')
GO
INSERT [dbo].[QuestionTags] ([QuestionID], [TagID]) VALUES (N'236efe44-d9e3-456a-9f5a-e98db457a50a', N'd6178ce7-1d7c-4ed9-ab68-2684567b74cb')
GO
INSERT [dbo].[QuestionTags] ([QuestionID], [TagID]) VALUES (N'236efe44-d9e3-456a-9f5a-e98db457a50a', N'0908d891-e526-44e7-a449-ec46d47e2050')
GO
