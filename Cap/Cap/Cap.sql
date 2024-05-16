/*
 Navicat Premium Data Transfer

 Source Server         : .
 Source Server Type    : SQL Server
 Source Server Version : 15002110 (15.00.2110)
 Source Host           : .:1433
 Source Catalog        : Cap
 Source Schema         : dbo

 Target Server Type    : SQL Server
 Target Server Version : 15002110 (15.00.2110)
 File Encoding         : 65001

 Date: 16/05/2024 17:06:18
*/


-- ----------------------------
-- Table structure for Alarm_Setting
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Alarm_Setting]') AND type IN ('U'))
	DROP TABLE [dbo].[Alarm_Setting]
GO

CREATE TABLE [dbo].[Alarm_Setting] (
  [Id] varchar(255) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [WarningMessage] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [Processvalue] int  NOT NULL,
  [CreateTime] datetime  NULL,
  [IsDelete] int  NULL
)
GO

ALTER TABLE [dbo].[Alarm_Setting] SET (LOCK_ESCALATION = TABLE)
GO

EXEC sp_addextendedproperty
'MS_Description', N'主键Id',
'SCHEMA', N'dbo',
'TABLE', N'Alarm_Setting',
'COLUMN', N'Id'
GO

EXEC sp_addextendedproperty
'MS_Description', N'告警信息',
'SCHEMA', N'dbo',
'TABLE', N'Alarm_Setting',
'COLUMN', N'WarningMessage'
GO

EXEC sp_addextendedproperty
'MS_Description', N'工艺乏值时间(秒)',
'SCHEMA', N'dbo',
'TABLE', N'Alarm_Setting',
'COLUMN', N'Processvalue'
GO

EXEC sp_addextendedproperty
'MS_Description', N'创建时间',
'SCHEMA', N'dbo',
'TABLE', N'Alarm_Setting',
'COLUMN', N'CreateTime'
GO


-- ----------------------------
-- Records of Alarm_Setting
-- ----------------------------
INSERT INTO [dbo].[Alarm_Setting] ([Id], [WarningMessage], [Processvalue], [CreateTime], [IsDelete]) VALUES (N'09e0263c-52c2-428c-87ec-d61e54de54d5', N'哈哈哈8888', N'10', N'2024-04-30 13:36:45.857', N'0')
GO

INSERT INTO [dbo].[Alarm_Setting] ([Id], [WarningMessage], [Processvalue], [CreateTime], [IsDelete]) VALUES (N'28949385-c922-49e8-bb2e-7fa56ff7a2ed', N'心心', N'9', N'2024-04-30 13:51:19.917', N'0')
GO

INSERT INTO [dbo].[Alarm_Setting] ([Id], [WarningMessage], [Processvalue], [CreateTime], [IsDelete]) VALUES (N'39175dba-a32e-471f-b4e7-05c71d4fa1af', N'心心', N'9', N'2024-04-30 13:51:05.767', N'99')
GO

INSERT INTO [dbo].[Alarm_Setting] ([Id], [WarningMessage], [Processvalue], [CreateTime], [IsDelete]) VALUES (N'416a8607-3a42-4cca-8833-1fd93e863def', N'心心', N'9', N'2024-04-30 13:51:21.297', N'0')
GO

INSERT INTO [dbo].[Alarm_Setting] ([Id], [WarningMessage], [Processvalue], [CreateTime], [IsDelete]) VALUES (N'42de7b74-39a8-435b-bf12-77c191b71666', N'心心', N'9', N'2024-04-30 13:51:07.307', N'99')
GO

INSERT INTO [dbo].[Alarm_Setting] ([Id], [WarningMessage], [Processvalue], [CreateTime], [IsDelete]) VALUES (N'538ab41e-af82-4353-8d4b-3876a79f19a1', N'心心', N'9', N'2024-04-30 13:51:18.253', N'0')
GO

INSERT INTO [dbo].[Alarm_Setting] ([Id], [WarningMessage], [Processvalue], [CreateTime], [IsDelete]) VALUES (N'5ee2312b-1fa5-4e15-b08d-92f18abe681d', N'心心', N'9', N'2024-04-30 13:51:02.407', N'0')
GO

INSERT INTO [dbo].[Alarm_Setting] ([Id], [WarningMessage], [Processvalue], [CreateTime], [IsDelete]) VALUES (N'6936a317-5249-4e11-b10f-19b830ad81e5', N'哈哈哈8888', N'10', N'2024-04-30 13:51:22.690', N'99')
GO

INSERT INTO [dbo].[Alarm_Setting] ([Id], [WarningMessage], [Processvalue], [CreateTime], [IsDelete]) VALUES (N'7b1c0dc4-148a-4093-9566-66798de70527', N'心心', N'9', N'2024-04-30 13:51:08.643', N'0')
GO

INSERT INTO [dbo].[Alarm_Setting] ([Id], [WarningMessage], [Processvalue], [CreateTime], [IsDelete]) VALUES (N'7d0b00df-87fd-4a25-b464-06344370001b', N'心心', N'9', N'2024-04-30 13:50:56.913', N'0')
GO

INSERT INTO [dbo].[Alarm_Setting] ([Id], [WarningMessage], [Processvalue], [CreateTime], [IsDelete]) VALUES (N'7fc1626d-f44d-41f1-ad9c-65bd1b188130', N'哈哈哈8888', N'10', N'2024-04-30 13:51:14.520', N'99')
GO

INSERT INTO [dbo].[Alarm_Setting] ([Id], [WarningMessage], [Processvalue], [CreateTime], [IsDelete]) VALUES (N'845b6430-03a8-499b-bf3a-07b86a7d100f', N'心心', N'9', N'2024-04-30 13:51:24.187', N'0')
GO

INSERT INTO [dbo].[Alarm_Setting] ([Id], [WarningMessage], [Processvalue], [CreateTime], [IsDelete]) VALUES (N'86583b65-fef3-4bb5-a547-8523d5bd76a8', N'哈哈哈8888', N'10', N'2024-04-30 13:51:12.710', N'0')
GO

INSERT INTO [dbo].[Alarm_Setting] ([Id], [WarningMessage], [Processvalue], [CreateTime], [IsDelete]) VALUES (N'8c9b5521-d439-44da-a7cd-dd02b9add62e', N'心心', N'9', N'2024-04-30 13:51:11.180', N'99')
GO

INSERT INTO [dbo].[Alarm_Setting] ([Id], [WarningMessage], [Processvalue], [CreateTime], [IsDelete]) VALUES (N'c35288d7-14bf-4f33-8960-9ffb5eff8680', N'心心', N'9', N'2024-04-30 13:51:09.893', N'99')
GO

INSERT INTO [dbo].[Alarm_Setting] ([Id], [WarningMessage], [Processvalue], [CreateTime], [IsDelete]) VALUES (N'ecd53fe9-32ec-4112-9d41-e7590f34e197', N'哈哈哈8888', N'10', N'2024-04-30 13:51:15.880', N'99')
GO

INSERT INTO [dbo].[Alarm_Setting] ([Id], [WarningMessage], [Processvalue], [CreateTime], [IsDelete]) VALUES (N'sda', N'的轨顶风道', N'5', N'2024-04-30 13:17:01.000', N'0')
GO


-- ----------------------------
-- Table structure for AuditLog
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[AuditLog]') AND type IN ('U'))
	DROP TABLE [dbo].[AuditLog]
GO

CREATE TABLE [dbo].[AuditLog] (
  [Id] varchar(255) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [UpdateEntity] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [IsSuccess] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [ModuleName] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [EntityName] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [LogType] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [Remark] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [NewValue] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [OldValue] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [CreationTime] datetime  NULL,
  [Creator] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL
)
GO

ALTER TABLE [dbo].[AuditLog] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of AuditLog
-- ----------------------------

-- ----------------------------
-- Table structure for BePutInStorage
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[BePutInStorage]') AND type IN ('U'))
	DROP TABLE [dbo].[BePutInStorage]
GO

CREATE TABLE [dbo].[BePutInStorage] (
  [Id] varchar(255) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [IncomingName] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [Contact] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [Phone] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [CreateTime] datetime  NULL,
  [CreateName] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [IsDelete] int  NULL
)
GO

ALTER TABLE [dbo].[BePutInStorage] SET (LOCK_ESCALATION = TABLE)
GO

EXEC sp_addextendedproperty
'MS_Description', N'主键Id',
'SCHEMA', N'dbo',
'TABLE', N'BePutInStorage',
'COLUMN', N'Id'
GO

EXEC sp_addextendedproperty
'MS_Description', N'入库名称',
'SCHEMA', N'dbo',
'TABLE', N'BePutInStorage',
'COLUMN', N'IncomingName'
GO

EXEC sp_addextendedproperty
'MS_Description', N'联系人',
'SCHEMA', N'dbo',
'TABLE', N'BePutInStorage',
'COLUMN', N'Contact'
GO

EXEC sp_addextendedproperty
'MS_Description', N'联系电话',
'SCHEMA', N'dbo',
'TABLE', N'BePutInStorage',
'COLUMN', N'Phone'
GO

EXEC sp_addextendedproperty
'MS_Description', N'创建时间',
'SCHEMA', N'dbo',
'TABLE', N'BePutInStorage',
'COLUMN', N'CreateTime'
GO

EXEC sp_addextendedproperty
'MS_Description', N'创建人',
'SCHEMA', N'dbo',
'TABLE', N'BePutInStorage',
'COLUMN', N'CreateName'
GO

EXEC sp_addextendedproperty
'MS_Description', N'是否删除(0否,99是)',
'SCHEMA', N'dbo',
'TABLE', N'BePutInStorage',
'COLUMN', N'IsDelete'
GO


-- ----------------------------
-- Records of BePutInStorage
-- ----------------------------
INSERT INTO [dbo].[BePutInStorage] ([Id], [IncomingName], [Contact], [Phone], [CreateTime], [CreateName], [IsDelete]) VALUES (N'f45c7d32-a0e0-41f9-8fc3-16a21605079a', N'第三方77777', N'说得好水电费', N'1111刚刚', N'2024-05-13 10:47:05.410', N'发生的', N'0')
GO

INSERT INTO [dbo].[BePutInStorage] ([Id], [IncomingName], [Contact], [Phone], [CreateTime], [CreateName], [IsDelete]) VALUES (N'fdf77ece-70a6-41b8-b00b-c1d7ff6b5042', N'第三方77777', N'说得好', N'1111', N'2024-05-13 10:47:00.227', N'发生的', N'99')
GO

INSERT INTO [dbo].[BePutInStorage] ([Id], [IncomingName], [Contact], [Phone], [CreateTime], [CreateName], [IsDelete]) VALUES (N'sdf', N'第三方地点', N'说得好供货商', N'1111发发发', N'2024-05-13 10:43:32.000', N'发生的刚刚好', N'0')
GO


-- ----------------------------
-- Table structure for BoxGaugeSetting
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[BoxGaugeSetting]') AND type IN ('U'))
	DROP TABLE [dbo].[BoxGaugeSetting]
GO

CREATE TABLE [dbo].[BoxGaugeSetting] (
  [Id] varchar(255) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [CaseGaugeName] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [ContainerLoad] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [ConsumableNumber] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [AccessoryName] varchar(1000) COLLATE Chinese_PRC_CI_AS  NULL,
  [AccessoryNum] varchar(1000) COLLATE Chinese_PRC_CI_AS  NULL,
  [CreateTime] datetime  NULL,
  [CreateName] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [IsDelete] int  NULL
)
GO

ALTER TABLE [dbo].[BoxGaugeSetting] SET (LOCK_ESCALATION = TABLE)
GO

EXEC sp_addextendedproperty
'MS_Description', N'主键Id',
'SCHEMA', N'dbo',
'TABLE', N'BoxGaugeSetting',
'COLUMN', N'Id'
GO

EXEC sp_addextendedproperty
'MS_Description', N'箱规名称',
'SCHEMA', N'dbo',
'TABLE', N'BoxGaugeSetting',
'COLUMN', N'CaseGaugeName'
GO

EXEC sp_addextendedproperty
'MS_Description', N'满箱数',
'SCHEMA', N'dbo',
'TABLE', N'BoxGaugeSetting',
'COLUMN', N'ContainerLoad'
GO

EXEC sp_addextendedproperty
'MS_Description', N'耗材数',
'SCHEMA', N'dbo',
'TABLE', N'BoxGaugeSetting',
'COLUMN', N'ConsumableNumber'
GO

EXEC sp_addextendedproperty
'MS_Description', N'辅料名称',
'SCHEMA', N'dbo',
'TABLE', N'BoxGaugeSetting',
'COLUMN', N'AccessoryName'
GO

EXEC sp_addextendedproperty
'MS_Description', N'辅料数量',
'SCHEMA', N'dbo',
'TABLE', N'BoxGaugeSetting',
'COLUMN', N'AccessoryNum'
GO

EXEC sp_addextendedproperty
'MS_Description', N'创建时间',
'SCHEMA', N'dbo',
'TABLE', N'BoxGaugeSetting',
'COLUMN', N'CreateTime'
GO

EXEC sp_addextendedproperty
'MS_Description', N'创建人',
'SCHEMA', N'dbo',
'TABLE', N'BoxGaugeSetting',
'COLUMN', N'CreateName'
GO

EXEC sp_addextendedproperty
'MS_Description', N'是否删除',
'SCHEMA', N'dbo',
'TABLE', N'BoxGaugeSetting',
'COLUMN', N'IsDelete'
GO


-- ----------------------------
-- Records of BoxGaugeSetting
-- ----------------------------
INSERT INTO [dbo].[BoxGaugeSetting] ([Id], [CaseGaugeName], [ContainerLoad], [ConsumableNumber], [AccessoryName], [AccessoryNum], [CreateTime], [CreateName], [IsDelete]) VALUES (N'0608bd04-17ed-4374-b3c6-421606dd97bb', N'测试箱规888', N'测试满箱数量777', N'耗材1; 耗材2; ', N'收到覅收到货;辅料名称222;收到覅收到货;辅料名称222;', N'100;12000;100;120;', N'2024-05-11 09:50:07.653', N'大力', N'0')
GO


-- ----------------------------
-- Table structure for Breadth
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Breadth]') AND type IN ('U'))
	DROP TABLE [dbo].[Breadth]
GO

CREATE TABLE [dbo].[Breadth] (
  [Id] varchar(255) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [BreadthName] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [WidthSize] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [WidthType] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [CreateTime] datetime  NULL,
  [CreateName] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [IsDelete] int  NULL
)
GO

ALTER TABLE [dbo].[Breadth] SET (LOCK_ESCALATION = TABLE)
GO

EXEC sp_addextendedproperty
'MS_Description', N'主键Id',
'SCHEMA', N'dbo',
'TABLE', N'Breadth',
'COLUMN', N'Id'
GO

EXEC sp_addextendedproperty
'MS_Description', N'幅宽名称',
'SCHEMA', N'dbo',
'TABLE', N'Breadth',
'COLUMN', N'BreadthName'
GO

EXEC sp_addextendedproperty
'MS_Description', N'幅宽大小',
'SCHEMA', N'dbo',
'TABLE', N'Breadth',
'COLUMN', N'WidthSize'
GO

EXEC sp_addextendedproperty
'MS_Description', N'幅宽类型',
'SCHEMA', N'dbo',
'TABLE', N'Breadth',
'COLUMN', N'WidthType'
GO

EXEC sp_addextendedproperty
'MS_Description', N'创建时间',
'SCHEMA', N'dbo',
'TABLE', N'Breadth',
'COLUMN', N'CreateTime'
GO

EXEC sp_addextendedproperty
'MS_Description', N'创建人',
'SCHEMA', N'dbo',
'TABLE', N'Breadth',
'COLUMN', N'CreateName'
GO

EXEC sp_addextendedproperty
'MS_Description', N'是否删除(0否,99是)',
'SCHEMA', N'dbo',
'TABLE', N'Breadth',
'COLUMN', N'IsDelete'
GO


-- ----------------------------
-- Records of Breadth
-- ----------------------------
INSERT INTO [dbo].[Breadth] ([Id], [BreadthName], [WidthSize], [WidthType], [CreateTime], [CreateName], [IsDelete]) VALUES (N'0a25b056-cef0-4a63-abad-e30e91bf4def', N'试试', N'100', N'后福', N'2024-04-30 15:41:55.973', N'管理员', N'0')
GO

INSERT INTO [dbo].[Breadth] ([Id], [BreadthName], [WidthSize], [WidthType], [CreateTime], [CreateName], [IsDelete]) VALUES (N'14b28109-9e5c-4586-9f59-18cbde44c280', N'大', N'1000', N'帽顶', N'2024-05-15 13:12:22.427', N'大力', N'0')
GO

INSERT INTO [dbo].[Breadth] ([Id], [BreadthName], [WidthSize], [WidthType], [CreateTime], [CreateName], [IsDelete]) VALUES (N'2bcf20f0-a957-4555-9271-6d415cdcbcac', N'试试111', N'1003333', N'帽顶', N'2024-04-30 15:41:53.903', N'管理员', N'0')
GO

INSERT INTO [dbo].[Breadth] ([Id], [BreadthName], [WidthSize], [WidthType], [CreateTime], [CreateName], [IsDelete]) VALUES (N'4833af24-21f2-4795-a577-fbc6156d167d', N'试试', N'100', N'后福', N'2024-04-30 14:56:02.723', N'管理员', N'99')
GO

INSERT INTO [dbo].[Breadth] ([Id], [BreadthName], [WidthSize], [WidthType], [CreateTime], [CreateName], [IsDelete]) VALUES (N'573e5190-d5c5-4267-84e6-3d750e51b789', N'试试11133电饭锅地方', N'1004344', N'帽顶', N'2024-04-30 15:03:41.960', N'管理员', N'99')
GO

INSERT INTO [dbo].[Breadth] ([Id], [BreadthName], [WidthSize], [WidthType], [CreateTime], [CreateName], [IsDelete]) VALUES (N'6235ef51-2991-4eac-b263-b088ea32d9a7', N'dsf', N'we', N'后福', N'2024-04-30 14:55:54.480', N'管理员', N'0')
GO

INSERT INTO [dbo].[Breadth] ([Id], [BreadthName], [WidthSize], [WidthType], [CreateTime], [CreateName], [IsDelete]) VALUES (N'66093ebd-bb38-4d79-a503-95bb5c975fc0', N'试试111', N'1003333', N'帽顶', N'2024-05-07 09:06:52.440', N'管理员', N'0')
GO

INSERT INTO [dbo].[Breadth] ([Id], [BreadthName], [WidthSize], [WidthType], [CreateTime], [CreateName], [IsDelete]) VALUES (N'6c15554d-30e3-491d-8f32-385aaceea3fc', N'试试', N'100', N'后福', N'2024-04-30 14:55:57.630', N'管理员', N'99')
GO

INSERT INTO [dbo].[Breadth] ([Id], [BreadthName], [WidthSize], [WidthType], [CreateTime], [CreateName], [IsDelete]) VALUES (N'6db577cb-33a7-4f56-9ab6-bbe99e45f817', N'试试', N'100', N'后福', N'2024-04-30 15:02:47.860', N'管理员', N'99')
GO

INSERT INTO [dbo].[Breadth] ([Id], [BreadthName], [WidthSize], [WidthType], [CreateTime], [CreateName], [IsDelete]) VALUES (N'73bb2931-a60d-4de7-974c-6f90ab41e28f', N'测试名称', N'111.00', N'侧幅', N'2024-05-16 10:26:30.627', N'大力', N'0')
GO

INSERT INTO [dbo].[Breadth] ([Id], [BreadthName], [WidthSize], [WidthType], [CreateTime], [CreateName], [IsDelete]) VALUES (N'81769566-15fe-49e5-8412-079aeeb21fe3', N'十点多', N'0', N'侧幅', N'2024-04-30 15:14:58.687', N'管理员', N'99')
GO

INSERT INTO [dbo].[Breadth] ([Id], [BreadthName], [WidthSize], [WidthType], [CreateTime], [CreateName], [IsDelete]) VALUES (N'8d40d60b-532b-412d-9f35-c7acef8b35df', N'试试', N'10000', N'后福', N'2024-04-30 14:56:05.407', N'管理员', N'0')
GO

INSERT INTO [dbo].[Breadth] ([Id], [BreadthName], [WidthSize], [WidthType], [CreateTime], [CreateName], [IsDelete]) VALUES (N'a67d90b3-8d1a-4b8a-9544-f5cca4f211fc', N'试试111', N'1003333', N'后福', N'2024-04-30 15:03:45.527', N'管理员', N'99')
GO

INSERT INTO [dbo].[Breadth] ([Id], [BreadthName], [WidthSize], [WidthType], [CreateTime], [CreateName], [IsDelete]) VALUES (N'b753d156-f13b-4e48-b24e-c1d7db97a2ae', N'试试', N'100', N'后福', N'2024-04-30 14:55:12.513', N'管理员', N'0')
GO

INSERT INTO [dbo].[Breadth] ([Id], [BreadthName], [WidthSize], [WidthType], [CreateTime], [CreateName], [IsDelete]) VALUES (N'b9b15d29-04a7-4663-8a8d-22786f88a912', N'dsf', N'we', N'1', N'2024-04-30 14:55:59.300', N'管理员', N'99')
GO

INSERT INTO [dbo].[Breadth] ([Id], [BreadthName], [WidthSize], [WidthType], [CreateTime], [CreateName], [IsDelete]) VALUES (N'bdb3a35f-e98c-43d6-8a17-97a429283c59', N'试试111', N'1003333', N'帽顶', N'2024-04-30 15:03:48.953', N'管理员', N'0')
GO

INSERT INTO [dbo].[Breadth] ([Id], [BreadthName], [WidthSize], [WidthType], [CreateTime], [CreateName], [IsDelete]) VALUES (N'c0f67048-23b5-4472-8f1f-c7711096ea74', N'试试3333', N'100', N'后福', N'2024-04-30 14:56:00.997', N'管理员', N'99')
GO

INSERT INTO [dbo].[Breadth] ([Id], [BreadthName], [WidthSize], [WidthType], [CreateTime], [CreateName], [IsDelete]) VALUES (N'c6fa0a67-06a5-4b84-82fb-cf1b7e125367', N'试试', N'100', N'后福', N'2024-04-30 14:56:04.110', N'管理员', N'99')
GO

INSERT INTO [dbo].[Breadth] ([Id], [BreadthName], [WidthSize], [WidthType], [CreateTime], [CreateName], [IsDelete]) VALUES (N'd46ac801-02e6-45b3-b68a-fc3a0a044ad2', N'试试', N'100', N'后福', N'2024-04-30 15:41:52.247', N'管理员', N'99')
GO

INSERT INTO [dbo].[Breadth] ([Id], [BreadthName], [WidthSize], [WidthType], [CreateTime], [CreateName], [IsDelete]) VALUES (N'd816652e-6166-4368-923a-a3da01822563', N'试试', N'100', N'后福', N'2024-05-06 09:10:01.300', N'管理员', N'0')
GO

INSERT INTO [dbo].[Breadth] ([Id], [BreadthName], [WidthSize], [WidthType], [CreateTime], [CreateName], [IsDelete]) VALUES (N'df', N'dsf', N'we', N'1', N'2024-04-30 14:34:52.000', N'sdf', N'99')
GO


-- ----------------------------
-- Table structure for Cap_AlarmManagement
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Cap_AlarmManagement]') AND type IN ('U'))
	DROP TABLE [dbo].[Cap_AlarmManagement]
GO

CREATE TABLE [dbo].[Cap_AlarmManagement] (
  [Id] varchar(255) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [AlarmContent] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [AlarmCause] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [WhetherTimelyProcessing] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [CreateTime] datetime2(7)  NULL,
  [CreateName] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [IsDelete] int  NULL
)
GO

ALTER TABLE [dbo].[Cap_AlarmManagement] SET (LOCK_ESCALATION = TABLE)
GO

EXEC sp_addextendedproperty
'MS_Description', N'主键Id',
'SCHEMA', N'dbo',
'TABLE', N'Cap_AlarmManagement',
'COLUMN', N'Id'
GO

EXEC sp_addextendedproperty
'MS_Description', N'告警内容',
'SCHEMA', N'dbo',
'TABLE', N'Cap_AlarmManagement',
'COLUMN', N'AlarmContent'
GO

EXEC sp_addextendedproperty
'MS_Description', N'告警原因',
'SCHEMA', N'dbo',
'TABLE', N'Cap_AlarmManagement',
'COLUMN', N'AlarmCause'
GO

EXEC sp_addextendedproperty
'MS_Description', N'是否及时处理',
'SCHEMA', N'dbo',
'TABLE', N'Cap_AlarmManagement',
'COLUMN', N'WhetherTimelyProcessing'
GO

EXEC sp_addextendedproperty
'MS_Description', N'创建时间',
'SCHEMA', N'dbo',
'TABLE', N'Cap_AlarmManagement',
'COLUMN', N'CreateTime'
GO

EXEC sp_addextendedproperty
'MS_Description', N'创建人',
'SCHEMA', N'dbo',
'TABLE', N'Cap_AlarmManagement',
'COLUMN', N'CreateName'
GO

EXEC sp_addextendedproperty
'MS_Description', N'是否删除(0否,99是)',
'SCHEMA', N'dbo',
'TABLE', N'Cap_AlarmManagement',
'COLUMN', N'IsDelete'
GO


-- ----------------------------
-- Records of Cap_AlarmManagement
-- ----------------------------
INSERT INTO [dbo].[Cap_AlarmManagement] ([Id], [AlarmContent], [AlarmCause], [WhetherTimelyProcessing], [CreateTime], [CreateName], [IsDelete]) VALUES (N'386246fd-2a1a-4653-99a2-2ec7b510b532', N'告警内容1', N'告警原因1123334444', N'是', N'2024-05-15 09:30:41.7575952', N'创建人1', N'0')
GO

INSERT INTO [dbo].[Cap_AlarmManagement] ([Id], [AlarmContent], [AlarmCause], [WhetherTimelyProcessing], [CreateTime], [CreateName], [IsDelete]) VALUES (N'6112836e-07e8-4c19-bff2-279e4cfc4ac2', N'告警内容111333', N'告警原因111444', N'是', N'2024-05-15 09:32:05.1797239', N'创建人1115555', N'99')
GO

INSERT INTO [dbo].[Cap_AlarmManagement] ([Id], [AlarmContent], [AlarmCause], [WhetherTimelyProcessing], [CreateTime], [CreateName], [IsDelete]) VALUES (N'a233c74b-e18b-4511-b48c-be50a58ad801', N'告警内容1呃呃', N'告警原因1123334444', N'是', N'2024-05-15 09:36:40.6339461', N'创建人1', N'0')
GO

INSERT INTO [dbo].[Cap_AlarmManagement] ([Id], [AlarmContent], [AlarmCause], [WhetherTimelyProcessing], [CreateTime], [CreateName], [IsDelete]) VALUES (N'df', N'告警内容', N'告警原因', N'是', N'2024-05-15 09:11:02.0000000', N'创建人', N'0')
GO


-- ----------------------------
-- Table structure for Cap_AttendanceManagement
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Cap_AttendanceManagement]') AND type IN ('U'))
	DROP TABLE [dbo].[Cap_AttendanceManagement]
GO

CREATE TABLE [dbo].[Cap_AttendanceManagement] (
  [Id] varchar(255) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [AttendanceDays] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [Timekeeper] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [CreateTime] datetime  NULL,
  [CreateName] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [IsDelete] int  NULL
)
GO

ALTER TABLE [dbo].[Cap_AttendanceManagement] SET (LOCK_ESCALATION = TABLE)
GO

EXEC sp_addextendedproperty
'MS_Description', N'主键Id',
'SCHEMA', N'dbo',
'TABLE', N'Cap_AttendanceManagement',
'COLUMN', N'Id'
GO

EXEC sp_addextendedproperty
'MS_Description', N'考勤天数',
'SCHEMA', N'dbo',
'TABLE', N'Cap_AttendanceManagement',
'COLUMN', N'AttendanceDays'
GO

EXEC sp_addextendedproperty
'MS_Description', N'考勤人',
'SCHEMA', N'dbo',
'TABLE', N'Cap_AttendanceManagement',
'COLUMN', N'Timekeeper'
GO

EXEC sp_addextendedproperty
'MS_Description', N'创建时间',
'SCHEMA', N'dbo',
'TABLE', N'Cap_AttendanceManagement',
'COLUMN', N'CreateTime'
GO

EXEC sp_addextendedproperty
'MS_Description', N'创建人',
'SCHEMA', N'dbo',
'TABLE', N'Cap_AttendanceManagement',
'COLUMN', N'CreateName'
GO

EXEC sp_addextendedproperty
'MS_Description', N'是否删除(0否,99是)',
'SCHEMA', N'dbo',
'TABLE', N'Cap_AttendanceManagement',
'COLUMN', N'IsDelete'
GO


-- ----------------------------
-- Records of Cap_AttendanceManagement
-- ----------------------------
INSERT INTO [dbo].[Cap_AttendanceManagement] ([Id], [AttendanceDays], [Timekeeper], [CreateTime], [CreateName], [IsDelete]) VALUES (N'96de1dce-11a8-4a4d-8a2c-c292b12bc375', N'3333截图', N'4444和', N'2024-05-14 14:28:13.157', N'5555很久', N'0')
GO

INSERT INTO [dbo].[Cap_AttendanceManagement] ([Id], [AttendanceDays], [Timekeeper], [CreateTime], [CreateName], [IsDelete]) VALUES (N'd8e1721f-f545-4753-b951-747f10b82287', N'111', N'222', N'2024-05-14 14:26:08.213', N'333', N'0')
GO

INSERT INTO [dbo].[Cap_AttendanceManagement] ([Id], [AttendanceDays], [Timekeeper], [CreateTime], [CreateName], [IsDelete]) VALUES (N'f061bfd4-56d7-42b4-b2ba-d64d4cedf438', N'111', N'2222', N'2024-05-14 14:26:03.170', N'', N'99')
GO


-- ----------------------------
-- Table structure for Cap_Company
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Cap_Company]') AND type IN ('U'))
	DROP TABLE [dbo].[Cap_Company]
GO

CREATE TABLE [dbo].[Cap_Company] (
  [Id] varchar(255) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [Company_Name] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [Authorization] int  NOT NULL,
  [CreateTime] datetime  NULL,
  [IsDelete] int  NULL
)
GO

ALTER TABLE [dbo].[Cap_Company] SET (LOCK_ESCALATION = TABLE)
GO

EXEC sp_addextendedproperty
'MS_Description', N'主键Id',
'SCHEMA', N'dbo',
'TABLE', N'Cap_Company',
'COLUMN', N'Id'
GO

EXEC sp_addextendedproperty
'MS_Description', N'公司名称',
'SCHEMA', N'dbo',
'TABLE', N'Cap_Company',
'COLUMN', N'Company_Name'
GO

EXEC sp_addextendedproperty
'MS_Description', N'是否授权(0否,1是)',
'SCHEMA', N'dbo',
'TABLE', N'Cap_Company',
'COLUMN', N'Authorization'
GO

EXEC sp_addextendedproperty
'MS_Description', N'创建时间',
'SCHEMA', N'dbo',
'TABLE', N'Cap_Company',
'COLUMN', N'CreateTime'
GO

EXEC sp_addextendedproperty
'MS_Description', N'是否删除(0否,99是)',
'SCHEMA', N'dbo',
'TABLE', N'Cap_Company',
'COLUMN', N'IsDelete'
GO


-- ----------------------------
-- Records of Cap_Company
-- ----------------------------
INSERT INTO [dbo].[Cap_Company] ([Id], [Company_Name], [Authorization], [CreateTime], [IsDelete]) VALUES (N'16a01b6d-345d-4eb0-82b1-6dace8c8003e', N'大幅度的534', N'1', N'2024-04-29 10:42:43.727', N'0')
GO

INSERT INTO [dbo].[Cap_Company] ([Id], [Company_Name], [Authorization], [CreateTime], [IsDelete]) VALUES (N'1c9511cd-c54f-47bf-a64e-9511782961a5', N'顶顶顶', N'1', N'2024-04-29 10:19:21.443', N'99')
GO

INSERT INTO [dbo].[Cap_Company] ([Id], [Company_Name], [Authorization], [CreateTime], [IsDelete]) VALUES (N'1c9a4dfc-e0a3-4a86-92bf-43cc4e6674f1', N'大幅度的', N'0', N'2024-04-29 10:17:28.927', N'99')
GO

INSERT INTO [dbo].[Cap_Company] ([Id], [Company_Name], [Authorization], [CreateTime], [IsDelete]) VALUES (N'2a7e852a-7740-4905-9f45-0f38f81cf13c', N'订单333', N'1', N'2024-04-29 10:19:18.683', N'99')
GO

INSERT INTO [dbo].[Cap_Company] ([Id], [Company_Name], [Authorization], [CreateTime], [IsDelete]) VALUES (N'2c1bdbd8-1751-4454-a39a-b690d7a46f78', N'顶顶顶', N'1', N'2024-04-29 09:48:55.620', N'0')
GO

INSERT INTO [dbo].[Cap_Company] ([Id], [Company_Name], [Authorization], [CreateTime], [IsDelete]) VALUES (N'32efe3c3-fd24-47e3-a956-339cdc9d4feb', N'大幅度的', N'1', N'2024-04-29 10:19:29.973', N'0')
GO

INSERT INTO [dbo].[Cap_Company] ([Id], [Company_Name], [Authorization], [CreateTime], [IsDelete]) VALUES (N'35a7c923-e723-4f21-a4d6-08f5fd970c2b', N'', N'1', N'2024-04-29 10:19:24.617', N'99')
GO

INSERT INTO [dbo].[Cap_Company] ([Id], [Company_Name], [Authorization], [CreateTime], [IsDelete]) VALUES (N'57423763-a22b-433b-84bd-b15d9d1fe6d4', N'顶顶顶', N'1', N'2024-04-29 10:06:32.847', N'99')
GO

INSERT INTO [dbo].[Cap_Company] ([Id], [Company_Name], [Authorization], [CreateTime], [IsDelete]) VALUES (N'5bfe5d1f-ec89-42de-bc0d-90f2a19267d3', N'大幅度的', N'0', N'2024-04-29 10:14:33.237', N'0')
GO

INSERT INTO [dbo].[Cap_Company] ([Id], [Company_Name], [Authorization], [CreateTime], [IsDelete]) VALUES (N'61f8b80a-9fa2-44b2-8306-151fd81283fb', N'', N'1', N'2024-04-29 10:19:16.653', N'99')
GO

INSERT INTO [dbo].[Cap_Company] ([Id], [Company_Name], [Authorization], [CreateTime], [IsDelete]) VALUES (N'6345ac18-beab-43fc-bba8-1282d9d6eca5', N'顶顶顶', N'1', N'2024-04-29 09:48:07.147', N'99')
GO

INSERT INTO [dbo].[Cap_Company] ([Id], [Company_Name], [Authorization], [CreateTime], [IsDelete]) VALUES (N'6e053cfb-6791-494a-92c1-6583f7ddc33b', N'', N'1', N'2024-04-29 09:48:41.677', N'99')
GO

INSERT INTO [dbo].[Cap_Company] ([Id], [Company_Name], [Authorization], [CreateTime], [IsDelete]) VALUES (N'7074a2f6-1ef1-448d-87c7-7d92c972903a', N'大幅度的', N'0', N'2024-04-29 10:19:31.590', N'0')
GO

INSERT INTO [dbo].[Cap_Company] ([Id], [Company_Name], [Authorization], [CreateTime], [IsDelete]) VALUES (N'8d6c28a5-bdcc-47d8-8e58-a7f2e2b9ef86', N'方法日日日', N'0', N'2024-04-29 10:08:12.290', N'0')
GO

INSERT INTO [dbo].[Cap_Company] ([Id], [Company_Name], [Authorization], [CreateTime], [IsDelete]) VALUES (N'93f391fc-85b1-4d2b-ba5e-3a32bcf004cd', N'', N'0', N'2024-04-29 09:48:37.550', N'99')
GO

INSERT INTO [dbo].[Cap_Company] ([Id], [Company_Name], [Authorization], [CreateTime], [IsDelete]) VALUES (N'9cb304e5-7bb1-4d48-8390-8aaf7a526e43', N'大幅度的534', N'1', N'2024-04-30 14:56:24.800', N'0')
GO

INSERT INTO [dbo].[Cap_Company] ([Id], [Company_Name], [Authorization], [CreateTime], [IsDelete]) VALUES (N'9f04b3a1-142a-4d4c-b231-309aef5cee68', N'给对方', N'1', N'2024-04-30 14:56:19.410', N'0')
GO

INSERT INTO [dbo].[Cap_Company] ([Id], [Company_Name], [Authorization], [CreateTime], [IsDelete]) VALUES (N'a0525452-36de-4b93-90f4-a84284101891', N'ddd', N'1', N'2024-04-29 10:03:30.000', N'99')
GO

INSERT INTO [dbo].[Cap_Company] ([Id], [Company_Name], [Authorization], [CreateTime], [IsDelete]) VALUES (N'a38d7b91-db94-49f6-96c3-37686c337ee9', N'大幅度的534', N'1', N'2024-04-30 14:56:17.623', N'0')
GO

INSERT INTO [dbo].[Cap_Company] ([Id], [Company_Name], [Authorization], [CreateTime], [IsDelete]) VALUES (N'a4f477ae-2d6f-409e-a87b-0f03666bab01', N'顶顶顶', N'1', N'2024-04-29 09:52:43.853', N'99')
GO

INSERT INTO [dbo].[Cap_Company] ([Id], [Company_Name], [Authorization], [CreateTime], [IsDelete]) VALUES (N'b6c324fb-da8a-4c5d-8d25-778be6327bec', N'给对方', N'0', N'2024-04-29 10:19:13.017', N'99')
GO

INSERT INTO [dbo].[Cap_Company] ([Id], [Company_Name], [Authorization], [CreateTime], [IsDelete]) VALUES (N'bf6d2e5e-e8a3-4397-b528-6a60fb6a59ce', N'方法22222', N'0', N'2024-04-29 10:42:40.503', N'99')
GO

INSERT INTO [dbo].[Cap_Company] ([Id], [Company_Name], [Authorization], [CreateTime], [IsDelete]) VALUES (N'c724079a-fcbf-45cc-877c-15ed90d6cf00', N'', N'1', N'2024-04-29 10:19:19.773', N'99')
GO

INSERT INTO [dbo].[Cap_Company] ([Id], [Company_Name], [Authorization], [CreateTime], [IsDelete]) VALUES (N'cc3f65f9-0991-4510-a066-a2e933d3d1d0', N'方法', N'0', N'2024-04-29 10:19:26.197', N'0')
GO

INSERT INTO [dbo].[Cap_Company] ([Id], [Company_Name], [Authorization], [CreateTime], [IsDelete]) VALUES (N'd380d215-2346-48d9-baa2-c5a1088924a0', N'方法日日日烦烦烦', N'0', N'2024-04-29 10:42:48.873', N'0')
GO

INSERT INTO [dbo].[Cap_Company] ([Id], [Company_Name], [Authorization], [CreateTime], [IsDelete]) VALUES (N'de3ad2ac-be57-46c6-9a86-2fc7bb51f69c', N'给对方43434333', N'1', N'2024-04-29 10:43:03.387', N'0')
GO

INSERT INTO [dbo].[Cap_Company] ([Id], [Company_Name], [Authorization], [CreateTime], [IsDelete]) VALUES (N'df', N'sdf', N'1', N'2024-04-28 15:29:58.000', N'99')
GO

INSERT INTO [dbo].[Cap_Company] ([Id], [Company_Name], [Authorization], [CreateTime], [IsDelete]) VALUES (N'dfa15af6-0753-4be4-a454-02b54db9e7de', N'订单333', N'1', N'2024-04-29 09:51:44.933', N'0')
GO

INSERT INTO [dbo].[Cap_Company] ([Id], [Company_Name], [Authorization], [CreateTime], [IsDelete]) VALUES (N'e46cf19d-f23b-4050-825a-4d69d9fa76c1', N'给对方', N'1', N'2024-04-29 10:05:52.983', N'0')
GO

INSERT INTO [dbo].[Cap_Company] ([Id], [Company_Name], [Authorization], [CreateTime], [IsDelete]) VALUES (N'e538ded3-adc7-4231-9ed0-44ef0ab75c46', N'大幅度的', N'0', N'2024-04-29 10:19:22.780', N'0')
GO

INSERT INTO [dbo].[Cap_Company] ([Id], [Company_Name], [Authorization], [CreateTime], [IsDelete]) VALUES (N'e607bdb4-a417-4050-aab6-490c16f09257', N'大幅度的', N'0', N'2024-04-30 14:56:27.000', N'0')
GO

INSERT INTO [dbo].[Cap_Company] ([Id], [Company_Name], [Authorization], [CreateTime], [IsDelete]) VALUES (N'eb9b0e65-2b4d-46dc-9f69-301081a73542', N'大幅度的', N'1', N'2024-04-29 10:05:49.173', N'0')
GO

INSERT INTO [dbo].[Cap_Company] ([Id], [Company_Name], [Authorization], [CreateTime], [IsDelete]) VALUES (N'edd051c9-c3ef-47f8-833c-a6348310cf86', N'大幅度的', N'0', N'2024-04-29 10:19:33.163', N'0')
GO

INSERT INTO [dbo].[Cap_Company] ([Id], [Company_Name], [Authorization], [CreateTime], [IsDelete]) VALUES (N'f32c87cc-40e4-44bc-9aed-bb86f7a14acc', N'给对方2223555', N'1', N'2024-05-15 13:42:26.660', N'0')
GO

INSERT INTO [dbo].[Cap_Company] ([Id], [Company_Name], [Authorization], [CreateTime], [IsDelete]) VALUES (N'f5195e9e-1919-4fcc-a849-0820d92be53c', N'顶顶顶', N'1', N'2024-04-29 10:08:57.290', N'99')
GO

INSERT INTO [dbo].[Cap_Company] ([Id], [Company_Name], [Authorization], [CreateTime], [IsDelete]) VALUES (N'f7aab96d-7dd5-4bfd-a759-19af78326c6c', N'方法', N'0', N'2024-04-29 16:53:28.817', N'0')
GO

INSERT INTO [dbo].[Cap_Company] ([Id], [Company_Name], [Authorization], [CreateTime], [IsDelete]) VALUES (N'fde0e43b-f1eb-4bee-81db-67b978a6bf8f', N'大幅度的534', N'1', N'2024-04-30 14:56:21.450', N'0')
GO


-- ----------------------------
-- Table structure for Cap_FinancialDailyAccount
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Cap_FinancialDailyAccount]') AND type IN ('U'))
	DROP TABLE [dbo].[Cap_FinancialDailyAccount]
GO

CREATE TABLE [dbo].[Cap_FinancialDailyAccount] (
  [Id] varchar(255) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [FinancialJournal] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [FixedAssets] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [OtherPurchases] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [CreateTime] datetime  NULL,
  [CreateName] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [IsDelete] int  NULL
)
GO

ALTER TABLE [dbo].[Cap_FinancialDailyAccount] SET (LOCK_ESCALATION = TABLE)
GO

EXEC sp_addextendedproperty
'MS_Description', N'主键Id',
'SCHEMA', N'dbo',
'TABLE', N'Cap_FinancialDailyAccount',
'COLUMN', N'Id'
GO

EXEC sp_addextendedproperty
'MS_Description', N'财务日账',
'SCHEMA', N'dbo',
'TABLE', N'Cap_FinancialDailyAccount',
'COLUMN', N'FinancialJournal'
GO

EXEC sp_addextendedproperty
'MS_Description', N'固定资产',
'SCHEMA', N'dbo',
'TABLE', N'Cap_FinancialDailyAccount',
'COLUMN', N'FixedAssets'
GO

EXEC sp_addextendedproperty
'MS_Description', N'其他采购',
'SCHEMA', N'dbo',
'TABLE', N'Cap_FinancialDailyAccount',
'COLUMN', N'OtherPurchases'
GO

EXEC sp_addextendedproperty
'MS_Description', N'创建时间',
'SCHEMA', N'dbo',
'TABLE', N'Cap_FinancialDailyAccount',
'COLUMN', N'CreateTime'
GO

EXEC sp_addextendedproperty
'MS_Description', N'创建人',
'SCHEMA', N'dbo',
'TABLE', N'Cap_FinancialDailyAccount',
'COLUMN', N'CreateName'
GO

EXEC sp_addextendedproperty
'MS_Description', N'是否删除(0否,99是)',
'SCHEMA', N'dbo',
'TABLE', N'Cap_FinancialDailyAccount',
'COLUMN', N'IsDelete'
GO


-- ----------------------------
-- Records of Cap_FinancialDailyAccount
-- ----------------------------
INSERT INTO [dbo].[Cap_FinancialDailyAccount] ([Id], [FinancialJournal], [FixedAssets], [OtherPurchases], [CreateTime], [CreateName], [IsDelete]) VALUES (N'17c73ab3-e160-4b3a-a2cd-b3bdbfc97ede', N'财务日账', N'资产', N'采购', N'2024-05-14 10:58:58.317', N'发发发', N'0')
GO

INSERT INTO [dbo].[Cap_FinancialDailyAccount] ([Id], [FinancialJournal], [FixedAssets], [OtherPurchases], [CreateTime], [CreateName], [IsDelete]) VALUES (N'5d6695b5-af10-412d-999a-fdd373f26244', N'第三方', N'', N'', N'2024-05-14 10:58:02.697', N'', N'0')
GO

INSERT INTO [dbo].[Cap_FinancialDailyAccount] ([Id], [FinancialJournal], [FixedAssets], [OtherPurchases], [CreateTime], [CreateName], [IsDelete]) VALUES (N'a7a0ddcb-074d-4252-a514-647bd4adb5d8', N'第', N'', N'', N'2024-05-14 11:03:10.963', N'', N'99')
GO

INSERT INTO [dbo].[Cap_FinancialDailyAccount] ([Id], [FinancialJournal], [FixedAssets], [OtherPurchases], [CreateTime], [CreateName], [IsDelete]) VALUES (N'b25c9fa3-e117-4016-87b9-74015badab38', N'财务日账17788', N'资产2900', N'采购3---8', N'2024-05-14 11:02:03.650', N'发发发4888', N'99')
GO


-- ----------------------------
-- Table structure for Cap_FinancialStatements
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Cap_FinancialStatements]') AND type IN ('U'))
	DROP TABLE [dbo].[Cap_FinancialStatements]
GO

CREATE TABLE [dbo].[Cap_FinancialStatements] (
  [Id] varchar(255) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [OrderNumber] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [NameOfMaterial] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [MaterialPrice] decimal(18,2)  NULL,
  [QuantityOfMaterial] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [GrossAmount] decimal(18,2)  NULL,
  [CreateTime] datetime  NULL,
  [CreateName] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [IsDelete] int  NULL
)
GO

ALTER TABLE [dbo].[Cap_FinancialStatements] SET (LOCK_ESCALATION = TABLE)
GO

EXEC sp_addextendedproperty
'MS_Description', N'主键Id',
'SCHEMA', N'dbo',
'TABLE', N'Cap_FinancialStatements',
'COLUMN', N'Id'
GO

EXEC sp_addextendedproperty
'MS_Description', N'订单号',
'SCHEMA', N'dbo',
'TABLE', N'Cap_FinancialStatements',
'COLUMN', N'OrderNumber'
GO

EXEC sp_addextendedproperty
'MS_Description', N'物料名称',
'SCHEMA', N'dbo',
'TABLE', N'Cap_FinancialStatements',
'COLUMN', N'NameOfMaterial'
GO

EXEC sp_addextendedproperty
'MS_Description', N'物料价格',
'SCHEMA', N'dbo',
'TABLE', N'Cap_FinancialStatements',
'COLUMN', N'MaterialPrice'
GO

EXEC sp_addextendedproperty
'MS_Description', N'物料数量',
'SCHEMA', N'dbo',
'TABLE', N'Cap_FinancialStatements',
'COLUMN', N'QuantityOfMaterial'
GO

EXEC sp_addextendedproperty
'MS_Description', N'总金额',
'SCHEMA', N'dbo',
'TABLE', N'Cap_FinancialStatements',
'COLUMN', N'GrossAmount'
GO

EXEC sp_addextendedproperty
'MS_Description', N'创建时间',
'SCHEMA', N'dbo',
'TABLE', N'Cap_FinancialStatements',
'COLUMN', N'CreateTime'
GO

EXEC sp_addextendedproperty
'MS_Description', N'创建人',
'SCHEMA', N'dbo',
'TABLE', N'Cap_FinancialStatements',
'COLUMN', N'CreateName'
GO

EXEC sp_addextendedproperty
'MS_Description', N'是否删除(0否,99是)',
'SCHEMA', N'dbo',
'TABLE', N'Cap_FinancialStatements',
'COLUMN', N'IsDelete'
GO


-- ----------------------------
-- Records of Cap_FinancialStatements
-- ----------------------------
INSERT INTO [dbo].[Cap_FinancialStatements] ([Id], [OrderNumber], [NameOfMaterial], [MaterialPrice], [QuantityOfMaterial], [GrossAmount], [CreateTime], [CreateName], [IsDelete]) VALUES (N'037437a5-4f4f-40f5-a786-6a4dff77fa75', N'阿萨德2222', N'测试名称111', N'330.00', N'100', N'200.00', N'2024-05-14 11:56:17.190', N'测试3333', N'99')
GO

INSERT INTO [dbo].[Cap_FinancialStatements] ([Id], [OrderNumber], [NameOfMaterial], [MaterialPrice], [QuantityOfMaterial], [GrossAmount], [CreateTime], [CreateName], [IsDelete]) VALUES (N'22818e88-dea1-44fe-a5b4-3031c72654b6', N'刚发的', N'付嘎达', N'11111.00', N'111', N'333333.00', N'2024-05-14 13:18:11.787', N'电饭锅', N'0')
GO

INSERT INTO [dbo].[Cap_FinancialStatements] ([Id], [OrderNumber], [NameOfMaterial], [MaterialPrice], [QuantityOfMaterial], [GrossAmount], [CreateTime], [CreateName], [IsDelete]) VALUES (N'2a66f77e-6332-4118-afad-7144fb63693e', N'付嘎达', N'刚发的', N'0.00', N'饭费', N'0.00', N'2024-05-14 13:17:58.617', N'滚滚滚', N'0')
GO

INSERT INTO [dbo].[Cap_FinancialStatements] ([Id], [OrderNumber], [NameOfMaterial], [MaterialPrice], [QuantityOfMaterial], [GrossAmount], [CreateTime], [CreateName], [IsDelete]) VALUES (N'4b502ca6-76f7-428b-8eaf-f9995881e30a', N'阿萨德2222', N'测试名称111', N'330.00', N'700', N'200.00', N'2024-05-14 11:56:19.560', N'测试3333', N'0')
GO

INSERT INTO [dbo].[Cap_FinancialStatements] ([Id], [OrderNumber], [NameOfMaterial], [MaterialPrice], [QuantityOfMaterial], [GrossAmount], [CreateTime], [CreateName], [IsDelete]) VALUES (N'a179f035-1614-4a8c-9313-1c9421a4191a', N'20240515171217153', N'测试A001', N'110.00', N'10', N'1100.00', N'2024-05-15 17:12:17.153', N'大力', N'0')
GO

INSERT INTO [dbo].[Cap_FinancialStatements] ([Id], [OrderNumber], [NameOfMaterial], [MaterialPrice], [QuantityOfMaterial], [GrossAmount], [CreateTime], [CreateName], [IsDelete]) VALUES (N'b5ff9727-7172-40e4-bc8c-e904036095ec', N'20240514133004635', N'大力物料给对方', N'10.00', N'99999', N'100.00', N'2024-05-14 13:30:07.453', N'大力广泛的', N'0')
GO

INSERT INTO [dbo].[Cap_FinancialStatements] ([Id], [OrderNumber], [NameOfMaterial], [MaterialPrice], [QuantityOfMaterial], [GrossAmount], [CreateTime], [CreateName], [IsDelete]) VALUES (N'e61554b4-2d2d-4729-957b-6d8957b32cde', N'阿萨德', N'测试名称', N'330.00', N'100', N'200.00', N'2024-05-14 11:56:07.723', N'测试', N'0')
GO


-- ----------------------------
-- Table structure for Cap_FixedAssets
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Cap_FixedAssets]') AND type IN ('U'))
	DROP TABLE [dbo].[Cap_FixedAssets]
GO

CREATE TABLE [dbo].[Cap_FixedAssets] (
  [Id] varchar(255) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [AssetNumber] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [AssetName] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [AcquisitionDate] datetime  NULL,
  [PurchaseAmount] decimal(18,2)  NULL,
  [AssetsClass] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [AssetStatus] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [Remark] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [CreateTime] datetime  NULL,
  [CreateName] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [IsDelete] int  NULL
)
GO

ALTER TABLE [dbo].[Cap_FixedAssets] SET (LOCK_ESCALATION = TABLE)
GO

EXEC sp_addextendedproperty
'MS_Description', N'主键Id',
'SCHEMA', N'dbo',
'TABLE', N'Cap_FixedAssets',
'COLUMN', N'Id'
GO

EXEC sp_addextendedproperty
'MS_Description', N'资产编号',
'SCHEMA', N'dbo',
'TABLE', N'Cap_FixedAssets',
'COLUMN', N'AssetNumber'
GO

EXEC sp_addextendedproperty
'MS_Description', N'资产名称',
'SCHEMA', N'dbo',
'TABLE', N'Cap_FixedAssets',
'COLUMN', N'AssetName'
GO

EXEC sp_addextendedproperty
'MS_Description', N'购置日期',
'SCHEMA', N'dbo',
'TABLE', N'Cap_FixedAssets',
'COLUMN', N'AcquisitionDate'
GO

EXEC sp_addextendedproperty
'MS_Description', N'购置金额',
'SCHEMA', N'dbo',
'TABLE', N'Cap_FixedAssets',
'COLUMN', N'PurchaseAmount'
GO

EXEC sp_addextendedproperty
'MS_Description', N'资产类别',
'SCHEMA', N'dbo',
'TABLE', N'Cap_FixedAssets',
'COLUMN', N'AssetsClass'
GO

EXEC sp_addextendedproperty
'MS_Description', N'资产状态',
'SCHEMA', N'dbo',
'TABLE', N'Cap_FixedAssets',
'COLUMN', N'AssetStatus'
GO

EXEC sp_addextendedproperty
'MS_Description', N'备注',
'SCHEMA', N'dbo',
'TABLE', N'Cap_FixedAssets',
'COLUMN', N'Remark'
GO

EXEC sp_addextendedproperty
'MS_Description', N'创建时间',
'SCHEMA', N'dbo',
'TABLE', N'Cap_FixedAssets',
'COLUMN', N'CreateTime'
GO

EXEC sp_addextendedproperty
'MS_Description', N'创建人',
'SCHEMA', N'dbo',
'TABLE', N'Cap_FixedAssets',
'COLUMN', N'CreateName'
GO

EXEC sp_addextendedproperty
'MS_Description', N'是否删除(0否,99是)',
'SCHEMA', N'dbo',
'TABLE', N'Cap_FixedAssets',
'COLUMN', N'IsDelete'
GO


-- ----------------------------
-- Records of Cap_FixedAssets
-- ----------------------------
INSERT INTO [dbo].[Cap_FixedAssets] ([Id], [AssetNumber], [AssetName], [AcquisitionDate], [PurchaseAmount], [AssetsClass], [AssetStatus], [Remark], [CreateTime], [CreateName], [IsDelete]) VALUES (N'76c2ed45-b5dc-4390-9a61-8a1c94808209', N'1', N'2', N'2024-05-20 15:59:57.000', N'7777.00', N'3', N'44444', N'5', N'2024-05-14 16:04:49.900', N'77777777', N'0')
GO

INSERT INTO [dbo].[Cap_FixedAssets] ([Id], [AssetNumber], [AssetName], [AcquisitionDate], [PurchaseAmount], [AssetsClass], [AssetStatus], [Remark], [CreateTime], [CreateName], [IsDelete]) VALUES (N'b3c75419-2229-4f62-9b9e-4ec30b187d9e', N'1', N'2', N'2024-05-16 15:59:57.000', N'0.00', N'3', N'4', N'566666', N'2024-05-14 16:00:15.457', N'7', N'0')
GO


-- ----------------------------
-- Table structure for Cap_OrderManagement
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Cap_OrderManagement]') AND type IN ('U'))
	DROP TABLE [dbo].[Cap_OrderManagement]
GO

CREATE TABLE [dbo].[Cap_OrderManagement] (
  [Id] varchar(255) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [ProductManagement] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [Quantity] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [Customer] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [Schedule] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [State] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [CreateTime] datetime  NULL,
  [CreateName] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [IsDelete] int  NULL
)
GO

ALTER TABLE [dbo].[Cap_OrderManagement] SET (LOCK_ESCALATION = TABLE)
GO

EXEC sp_addextendedproperty
'MS_Description', N'主键Id',
'SCHEMA', N'dbo',
'TABLE', N'Cap_OrderManagement',
'COLUMN', N'Id'
GO

EXEC sp_addextendedproperty
'MS_Description', N'产品管理',
'SCHEMA', N'dbo',
'TABLE', N'Cap_OrderManagement',
'COLUMN', N'ProductManagement'
GO

EXEC sp_addextendedproperty
'MS_Description', N'数量',
'SCHEMA', N'dbo',
'TABLE', N'Cap_OrderManagement',
'COLUMN', N'Quantity'
GO

EXEC sp_addextendedproperty
'MS_Description', N'客户',
'SCHEMA', N'dbo',
'TABLE', N'Cap_OrderManagement',
'COLUMN', N'Customer'
GO

EXEC sp_addextendedproperty
'MS_Description', N'进度',
'SCHEMA', N'dbo',
'TABLE', N'Cap_OrderManagement',
'COLUMN', N'Schedule'
GO

EXEC sp_addextendedproperty
'MS_Description', N'状态',
'SCHEMA', N'dbo',
'TABLE', N'Cap_OrderManagement',
'COLUMN', N'State'
GO

EXEC sp_addextendedproperty
'MS_Description', N'创建时间',
'SCHEMA', N'dbo',
'TABLE', N'Cap_OrderManagement',
'COLUMN', N'CreateTime'
GO

EXEC sp_addextendedproperty
'MS_Description', N'创建人',
'SCHEMA', N'dbo',
'TABLE', N'Cap_OrderManagement',
'COLUMN', N'CreateName'
GO

EXEC sp_addextendedproperty
'MS_Description', N'是否删除(0否,99是)',
'SCHEMA', N'dbo',
'TABLE', N'Cap_OrderManagement',
'COLUMN', N'IsDelete'
GO


-- ----------------------------
-- Records of Cap_OrderManagement
-- ----------------------------
INSERT INTO [dbo].[Cap_OrderManagement] ([Id], [ProductManagement], [Quantity], [Customer], [Schedule], [State], [CreateTime], [CreateName], [IsDelete]) VALUES (N'51f412a5-9b21-4434-9db4-a72395456dbd', N'反个', N'', N'', N'', N'', NULL, N'', N'99')
GO

INSERT INTO [dbo].[Cap_OrderManagement] ([Id], [ProductManagement], [Quantity], [Customer], [Schedule], [State], [CreateTime], [CreateName], [IsDelete]) VALUES (N'652f6342-2208-4b63-b307-6a492b1d17c5', N'', N'', N'', N'', N'', NULL, N'大力', N'0')
GO

INSERT INTO [dbo].[Cap_OrderManagement] ([Id], [ProductManagement], [Quantity], [Customer], [Schedule], [State], [CreateTime], [CreateName], [IsDelete]) VALUES (N'c4fa464e-ee7c-4c67-9e15-2c65f7c7bedc', N'', N'', N'梵蒂冈', N'', N'', NULL, N'', N'99')
GO

INSERT INTO [dbo].[Cap_OrderManagement] ([Id], [ProductManagement], [Quantity], [Customer], [Schedule], [State], [CreateTime], [CreateName], [IsDelete]) VALUES (N'sdf ', N'67888', N'士大夫侮辱', N'发过火发过的', N'地方黑胡椒', N'发发发发会更好', N'2024-05-13 14:14:32.000', N'士大夫交换机', N'99')
GO


-- ----------------------------
-- Table structure for Cap_OrderSplitting
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Cap_OrderSplitting]') AND type IN ('U'))
	DROP TABLE [dbo].[Cap_OrderSplitting]
GO

CREATE TABLE [dbo].[Cap_OrderSplitting] (
  [Id] varchar(255) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [OrderName] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [CreateTime] datetime  NULL,
  [CreateName] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [IsDelete] int  NULL
)
GO

ALTER TABLE [dbo].[Cap_OrderSplitting] SET (LOCK_ESCALATION = TABLE)
GO

EXEC sp_addextendedproperty
'MS_Description', N'主键Id',
'SCHEMA', N'dbo',
'TABLE', N'Cap_OrderSplitting',
'COLUMN', N'Id'
GO

EXEC sp_addextendedproperty
'MS_Description', N'订单名称',
'SCHEMA', N'dbo',
'TABLE', N'Cap_OrderSplitting',
'COLUMN', N'OrderName'
GO

EXEC sp_addextendedproperty
'MS_Description', N'创建时间',
'SCHEMA', N'dbo',
'TABLE', N'Cap_OrderSplitting',
'COLUMN', N'CreateTime'
GO

EXEC sp_addextendedproperty
'MS_Description', N'创建人',
'SCHEMA', N'dbo',
'TABLE', N'Cap_OrderSplitting',
'COLUMN', N'CreateName'
GO

EXEC sp_addextendedproperty
'MS_Description', N'是否删除(0否,99是)',
'SCHEMA', N'dbo',
'TABLE', N'Cap_OrderSplitting',
'COLUMN', N'IsDelete'
GO


-- ----------------------------
-- Records of Cap_OrderSplitting
-- ----------------------------
INSERT INTO [dbo].[Cap_OrderSplitting] ([Id], [OrderName], [CreateTime], [CreateName], [IsDelete]) VALUES (N'56e7d91a-46fc-4854-9507-2e7de009bba7', N'给对方UI计划水电费发发发', N'2024-05-13 14:59:41.543', N'大公会的干哈的', N'0')
GO

INSERT INTO [dbo].[Cap_OrderSplitting] ([Id], [OrderName], [CreateTime], [CreateName], [IsDelete]) VALUES (N'ada36b6d-f9a2-433c-92ec-41aa40f58c69', N'水电费v出v', N'2024-05-13 14:59:31.543', N'', N'99')
GO

INSERT INTO [dbo].[Cap_OrderSplitting] ([Id], [OrderName], [CreateTime], [CreateName], [IsDelete]) VALUES (N'c7051820-20c2-4205-84e8-00cf629cf88b', N'给对方UI计划水电费发发发', N'2024-05-13 15:07:14.517', N'大公会的干哈的', N'0')
GO


-- ----------------------------
-- Table structure for Cap_PurchasingManagement
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Cap_PurchasingManagement]') AND type IN ('U'))
	DROP TABLE [dbo].[Cap_PurchasingManagement]
GO

CREATE TABLE [dbo].[Cap_PurchasingManagement] (
  [Id] varchar(255) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [OrderNumber] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [OrderQuantity] int  NULL,
  [OrderName] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [CreateTime] datetime  NULL,
  [CreateName] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [IsDelete] int  NULL
)
GO

ALTER TABLE [dbo].[Cap_PurchasingManagement] SET (LOCK_ESCALATION = TABLE)
GO

EXEC sp_addextendedproperty
'MS_Description', N'主键Id',
'SCHEMA', N'dbo',
'TABLE', N'Cap_PurchasingManagement',
'COLUMN', N'Id'
GO

EXEC sp_addextendedproperty
'MS_Description', N'订单号',
'SCHEMA', N'dbo',
'TABLE', N'Cap_PurchasingManagement',
'COLUMN', N'OrderNumber'
GO

EXEC sp_addextendedproperty
'MS_Description', N'订单数量',
'SCHEMA', N'dbo',
'TABLE', N'Cap_PurchasingManagement',
'COLUMN', N'OrderQuantity'
GO

EXEC sp_addextendedproperty
'MS_Description', N'订单名称',
'SCHEMA', N'dbo',
'TABLE', N'Cap_PurchasingManagement',
'COLUMN', N'OrderName'
GO

EXEC sp_addextendedproperty
'MS_Description', N'创建时间',
'SCHEMA', N'dbo',
'TABLE', N'Cap_PurchasingManagement',
'COLUMN', N'CreateTime'
GO

EXEC sp_addextendedproperty
'MS_Description', N'创建人',
'SCHEMA', N'dbo',
'TABLE', N'Cap_PurchasingManagement',
'COLUMN', N'CreateName'
GO

EXEC sp_addextendedproperty
'MS_Description', N'是否删除(0否,99是)',
'SCHEMA', N'dbo',
'TABLE', N'Cap_PurchasingManagement',
'COLUMN', N'IsDelete'
GO


-- ----------------------------
-- Records of Cap_PurchasingManagement
-- ----------------------------
INSERT INTO [dbo].[Cap_PurchasingManagement] ([Id], [OrderNumber], [OrderQuantity], [OrderName], [CreateTime], [CreateName], [IsDelete]) VALUES (N'12dcfba9-2203-4a3c-92e0-f4db84a07c21', N'202405-14151243675', N'333', N'444', N'2024-05-14 15:12:43.677', N'555', N'99')
GO

INSERT INTO [dbo].[Cap_PurchasingManagement] ([Id], [OrderNumber], [OrderQuantity], [OrderName], [CreateTime], [CreateName], [IsDelete]) VALUES (N'529257ab-6c4e-4b4a-96b2-9a46b7fa02cc', N'20240514151603199', N'444788888', N'555', N'2024-05-14 15:16:03.200', N'99999999', N'99')
GO

INSERT INTO [dbo].[Cap_PurchasingManagement] ([Id], [OrderNumber], [OrderQuantity], [OrderName], [CreateTime], [CreateName], [IsDelete]) VALUES (N'7b99f83a-e960-449e-8a04-ed3ca119206c', N'20240514151314781', N'666', N'顶顶顶顶', N'2024-05-14 15:13:14.783', N'888', N'99')
GO

INSERT INTO [dbo].[Cap_PurchasingManagement] ([Id], [OrderNumber], [OrderQuantity], [OrderName], [CreateTime], [CreateName], [IsDelete]) VALUES (N'86d4fbdd-8f2f-4a57-8e36-81aa555335b1', N'20240514151305950', N'444', N'烦烦烦', N'2024-05-14 15:13:05.950', N'灌灌灌灌', N'0')
GO

INSERT INTO [dbo].[Cap_PurchasingManagement] ([Id], [OrderNumber], [OrderQuantity], [OrderName], [CreateTime], [CreateName], [IsDelete]) VALUES (N'e903ea22-3c40-4ef6-9777-b7a4e13c5ae1', N'20240514151428264', N'6665676', N'77733', N'2024-05-14 15:14:28.263', N'88853', N'0')
GO


-- ----------------------------
-- Table structure for Cap_WorkerManagement
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Cap_WorkerManagement]') AND type IN ('U'))
	DROP TABLE [dbo].[Cap_WorkerManagement]
GO

CREATE TABLE [dbo].[Cap_WorkerManagement] (
  [Id] varchar(255) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [NameOfWorker] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [Message] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [BasicInformation] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [CreateTime] datetime  NULL,
  [CreateName] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [IsDelete] int  NULL
)
GO

ALTER TABLE [dbo].[Cap_WorkerManagement] SET (LOCK_ESCALATION = TABLE)
GO

EXEC sp_addextendedproperty
'MS_Description', N'主键Id',
'SCHEMA', N'dbo',
'TABLE', N'Cap_WorkerManagement',
'COLUMN', N'Id'
GO

EXEC sp_addextendedproperty
'MS_Description', N'工人名称',
'SCHEMA', N'dbo',
'TABLE', N'Cap_WorkerManagement',
'COLUMN', N'NameOfWorker'
GO

EXEC sp_addextendedproperty
'MS_Description', N'基本信息',
'SCHEMA', N'dbo',
'TABLE', N'Cap_WorkerManagement',
'COLUMN', N'Message'
GO

EXEC sp_addextendedproperty
'MS_Description', N'工艺信息',
'SCHEMA', N'dbo',
'TABLE', N'Cap_WorkerManagement',
'COLUMN', N'BasicInformation'
GO

EXEC sp_addextendedproperty
'MS_Description', N'创建时间',
'SCHEMA', N'dbo',
'TABLE', N'Cap_WorkerManagement',
'COLUMN', N'CreateTime'
GO

EXEC sp_addextendedproperty
'MS_Description', N'创建人',
'SCHEMA', N'dbo',
'TABLE', N'Cap_WorkerManagement',
'COLUMN', N'CreateName'
GO

EXEC sp_addextendedproperty
'MS_Description', N'是否删除(0否,99是)',
'SCHEMA', N'dbo',
'TABLE', N'Cap_WorkerManagement',
'COLUMN', N'IsDelete'
GO


-- ----------------------------
-- Records of Cap_WorkerManagement
-- ----------------------------
INSERT INTO [dbo].[Cap_WorkerManagement] ([Id], [NameOfWorker], [Message], [BasicInformation], [CreateTime], [CreateName], [IsDelete]) VALUES (N'1c328fdd-37ae-4b93-b325-99681576d313', N'地方', N'收到分摊', N'电饭锅', N'2024-05-13 16:41:17.377', NULL, N'0')
GO

INSERT INTO [dbo].[Cap_WorkerManagement] ([Id], [NameOfWorker], [Message], [BasicInformation], [CreateTime], [CreateName], [IsDelete]) VALUES (N'77433267-6c6b-49e7-bfdb-aaa789ec863a', N'地方', N'收到分摊', N'电饭锅·', N'2024-05-13 16:27:18.870', NULL, N'0')
GO

INSERT INTO [dbo].[Cap_WorkerManagement] ([Id], [NameOfWorker], [Message], [BasicInformation], [CreateTime], [CreateName], [IsDelete]) VALUES (N'b7619048-8955-4843-8417-151dc9329c2a', N'地方', N'收发给 干火锅', N'电饭锅·', N'2024-05-13 17:00:17.960', NULL, N'0')
GO

INSERT INTO [dbo].[Cap_WorkerManagement] ([Id], [NameOfWorker], [Message], [BasicInformation], [CreateTime], [CreateName], [IsDelete]) VALUES (N'f685c4f7-23ae-4274-80d1-d699b2534683', N'地方', N'收到分摊', N'电饭锅·', N'2024-05-13 17:00:13.007', NULL, N'0')
GO

INSERT INTO [dbo].[Cap_WorkerManagement] ([Id], [NameOfWorker], [Message], [BasicInformation], [CreateTime], [CreateName], [IsDelete]) VALUES (N'sdf', N'地方', N'收到分摊', N'电饭锅·', N'2024-05-13 16:26:32.000', N'电饭锅', N'0')
GO


-- ----------------------------
-- Table structure for Cap_WorkRecord
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Cap_WorkRecord]') AND type IN ('U'))
	DROP TABLE [dbo].[Cap_WorkRecord]
GO

CREATE TABLE [dbo].[Cap_WorkRecord] (
  [Id] varchar(255) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [JobTitle] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [Logging] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [Statistics] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [CreateTime] datetime  NULL,
  [CreateName] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [IsDelete] int  NULL
)
GO

ALTER TABLE [dbo].[Cap_WorkRecord] SET (LOCK_ESCALATION = TABLE)
GO

EXEC sp_addextendedproperty
'MS_Description', N'主键Id',
'SCHEMA', N'dbo',
'TABLE', N'Cap_WorkRecord',
'COLUMN', N'Id'
GO

EXEC sp_addextendedproperty
'MS_Description', N'工作名称',
'SCHEMA', N'dbo',
'TABLE', N'Cap_WorkRecord',
'COLUMN', N'JobTitle'
GO

EXEC sp_addextendedproperty
'MS_Description', N'工作记录',
'SCHEMA', N'dbo',
'TABLE', N'Cap_WorkRecord',
'COLUMN', N'Logging'
GO

EXEC sp_addextendedproperty
'MS_Description', N'统计',
'SCHEMA', N'dbo',
'TABLE', N'Cap_WorkRecord',
'COLUMN', N'Statistics'
GO

EXEC sp_addextendedproperty
'MS_Description', N'创建时间',
'SCHEMA', N'dbo',
'TABLE', N'Cap_WorkRecord',
'COLUMN', N'CreateTime'
GO

EXEC sp_addextendedproperty
'MS_Description', N'创建人',
'SCHEMA', N'dbo',
'TABLE', N'Cap_WorkRecord',
'COLUMN', N'CreateName'
GO

EXEC sp_addextendedproperty
'MS_Description', N'是否删除(0否,99是)',
'SCHEMA', N'dbo',
'TABLE', N'Cap_WorkRecord',
'COLUMN', N'IsDelete'
GO


-- ----------------------------
-- Records of Cap_WorkRecord
-- ----------------------------
INSERT INTO [dbo].[Cap_WorkRecord] ([Id], [JobTitle], [Logging], [Statistics], [CreateTime], [CreateName], [IsDelete]) VALUES (N'80f73587-0ffd-481c-9e41-a4cfcbdb52c2', N'地方', N'萨芬', N'电饭锅', N'2024-05-14 10:35:12.093', N'收到', N'99')
GO

INSERT INTO [dbo].[Cap_WorkRecord] ([Id], [JobTitle], [Logging], [Statistics], [CreateTime], [CreateName], [IsDelete]) VALUES (N'a70b9210-9cb7-4acb-ae25-eeb7ed123af2', N'给对方', N'贵航股份', N'饭费', N'2024-05-14 10:35:19.523', N'刚刚', N'0')
GO

INSERT INTO [dbo].[Cap_WorkRecord] ([Id], [JobTitle], [Logging], [Statistics], [CreateTime], [CreateName], [IsDelete]) VALUES (N'e3f93edd-b9a6-42fd-b0cf-52f3e9e42261', N'给对方刚刚534', N'贵航股份345', N'饭费染发的3345', N'2024-05-14 10:35:28.053', N'刚刚哈哈哈哈2322', N'99')
GO


-- ----------------------------
-- Table structure for ChargeTime
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[ChargeTime]') AND type IN ('U'))
	DROP TABLE [dbo].[ChargeTime]
GO

CREATE TABLE [dbo].[ChargeTime] (
  [Id] varchar(255) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [AccessoryName] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [Unit] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [CreateTime] datetime  NULL,
  [CreateName] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [IsDelete] int  NULL
)
GO

ALTER TABLE [dbo].[ChargeTime] SET (LOCK_ESCALATION = TABLE)
GO

EXEC sp_addextendedproperty
'MS_Description', N'主键Id',
'SCHEMA', N'dbo',
'TABLE', N'ChargeTime',
'COLUMN', N'Id'
GO

EXEC sp_addextendedproperty
'MS_Description', N'辅料名称',
'SCHEMA', N'dbo',
'TABLE', N'ChargeTime',
'COLUMN', N'AccessoryName'
GO

EXEC sp_addextendedproperty
'MS_Description', N'单位',
'SCHEMA', N'dbo',
'TABLE', N'ChargeTime',
'COLUMN', N'Unit'
GO

EXEC sp_addextendedproperty
'MS_Description', N'创建时间',
'SCHEMA', N'dbo',
'TABLE', N'ChargeTime',
'COLUMN', N'CreateTime'
GO

EXEC sp_addextendedproperty
'MS_Description', N'创建人',
'SCHEMA', N'dbo',
'TABLE', N'ChargeTime',
'COLUMN', N'CreateName'
GO

EXEC sp_addextendedproperty
'MS_Description', N'是否删除(0否,99是)',
'SCHEMA', N'dbo',
'TABLE', N'ChargeTime',
'COLUMN', N'IsDelete'
GO


-- ----------------------------
-- Records of ChargeTime
-- ----------------------------
INSERT INTO [dbo].[ChargeTime] ([Id], [AccessoryName], [Unit], [CreateTime], [CreateName], [IsDelete]) VALUES (N'2d8ff352-b1ce-45de-a424-536af066f3bb', N'收到覅收到货', N'辅料3', N'2024-05-08 15:01:55.607', N'创建人333', N'0')
GO

INSERT INTO [dbo].[ChargeTime] ([Id], [AccessoryName], [Unit], [CreateTime], [CreateName], [IsDelete]) VALUES (N'341629b2-9f8d-459e-9f52-18f6b9465184', N'辅料名称222', N'辅料3', N'2024-05-07 11:55:34.213', N'创建人333', N'0')
GO

INSERT INTO [dbo].[ChargeTime] ([Id], [AccessoryName], [Unit], [CreateTime], [CreateName], [IsDelete]) VALUES (N'41bcbfb6-49bb-4d78-a481-7bb1e5dfc0d9', N'豆腐干地方', N'辅料4', N'2024-05-07 11:55:45.103', N'给对方', N'0')
GO

INSERT INTO [dbo].[ChargeTime] ([Id], [AccessoryName], [Unit], [CreateTime], [CreateName], [IsDelete]) VALUES (N'4dcb9201-18c1-49d8-a549-4114bbbd033d', N'收到覅收到货99999', N'辅料3', N'2024-05-16 10:48:06.857', N'大力', N'0')
GO

INSERT INTO [dbo].[ChargeTime] ([Id], [AccessoryName], [Unit], [CreateTime], [CreateName], [IsDelete]) VALUES (N'6c95fc1b-aef2-4834-a815-87cd88af47c7', N'豆腐干地方第三方', N'辅料4', N'2024-05-08 15:02:05.213', N'给对方四点发给', N'0')
GO

INSERT INTO [dbo].[ChargeTime] ([Id], [AccessoryName], [Unit], [CreateTime], [CreateName], [IsDelete]) VALUES (N'82e6e21d-2a54-4432-841e-50e975dc1706', N' 顶顶顶方法', N'辅料3', N'2024-05-07 11:58:26.503', N'创建人333', N'0')
GO

INSERT INTO [dbo].[ChargeTime] ([Id], [AccessoryName], [Unit], [CreateTime], [CreateName], [IsDelete]) VALUES (N'8c564349-1044-4ea3-b451-175fb96a6988', N'豆腐干地方', N'辅料4', N'2024-05-08 15:50:20.587', N'给对方', N'0')
GO

INSERT INTO [dbo].[ChargeTime] ([Id], [AccessoryName], [Unit], [CreateTime], [CreateName], [IsDelete]) VALUES (N'950668ee-b64c-4ed4-982e-84a65d6ed33f', N'辅料名称222232444', N'辅料3', N'2024-05-15 17:07:52.053', N'大力', N'0')
GO

INSERT INTO [dbo].[ChargeTime] ([Id], [AccessoryName], [Unit], [CreateTime], [CreateName], [IsDelete]) VALUES (N'a6d6dd94-78e2-46d1-8af4-cde02a3c17d2', N'豆腐干地方', N'辅料4', N'2024-05-07 13:12:51.567', N'给对方四点', N'0')
GO

INSERT INTO [dbo].[ChargeTime] ([Id], [AccessoryName], [Unit], [CreateTime], [CreateName], [IsDelete]) VALUES (N'a7806fce-476e-4374-92c9-c240eb89fe67', N'豆腐干地方', N'辅料4', N'2024-05-07 11:57:28.857', N'给对方四点', N'0')
GO

INSERT INTO [dbo].[ChargeTime] ([Id], [AccessoryName], [Unit], [CreateTime], [CreateName], [IsDelete]) VALUES (N'a828df6e-26a6-4b05-bab5-689f3d8119b9', N'辅料名称222232', N'辅料3', N'2024-05-07 11:55:36.953', N'创建人333', N'0')
GO

INSERT INTO [dbo].[ChargeTime] ([Id], [AccessoryName], [Unit], [CreateTime], [CreateName], [IsDelete]) VALUES (N'b89cd123-3bd2-4294-8a3b-ec7b44f01ae6', N'豆腐干地方', N'辅料4', N'2024-05-08 15:01:48.827', N'给对方', N'0')
GO

INSERT INTO [dbo].[ChargeTime] ([Id], [AccessoryName], [Unit], [CreateTime], [CreateName], [IsDelete]) VALUES (N'c0fe1fe1-9e8e-4c26-a37d-4d4e462c9f1e', N' 顶顶顶', N'辅料3', N'2024-05-07 11:56:16.803', N'创建人333', N'0')
GO

INSERT INTO [dbo].[ChargeTime] ([Id], [AccessoryName], [Unit], [CreateTime], [CreateName], [IsDelete]) VALUES (N'c1c6f4d9-b79e-491d-ae78-1146fad1aed9', N' 顶顶顶', N'辅料3', N'2024-05-07 13:12:49.270', N'创建人333', N'0')
GO

INSERT INTO [dbo].[ChargeTime] ([Id], [AccessoryName], [Unit], [CreateTime], [CreateName], [IsDelete]) VALUES (N'e781ab7b-fd6a-4c4e-9eb7-aef6a0b05712', N'的发射点', N'', N'2024-05-07 11:55:39.343', N'', N'0')
GO

INSERT INTO [dbo].[ChargeTime] ([Id], [AccessoryName], [Unit], [CreateTime], [CreateName], [IsDelete]) VALUES (N'f770bd1d-8bef-4398-8349-92fa96d2d19e', N'收到覅收到货', N'辅料3', N'2024-05-08 15:25:52.640', N'创建人333', N'0')
GO

INSERT INTO [dbo].[ChargeTime] ([Id], [AccessoryName], [Unit], [CreateTime], [CreateName], [IsDelete]) VALUES (N'fv', N'辅料名称222', N'辅料3', N'2024-05-07 11:35:36.000', N'创建人333', N'0')
GO


-- ----------------------------
-- Table structure for Consumer
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Consumer]') AND type IN ('U'))
	DROP TABLE [dbo].[Consumer]
GO

CREATE TABLE [dbo].[Consumer] (
  [Id] varchar(255) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [CustomerName] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [Contact] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [Phone] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [CreateTime] datetime  NULL,
  [CreateName] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [IsDelete] int  NULL
)
GO

ALTER TABLE [dbo].[Consumer] SET (LOCK_ESCALATION = TABLE)
GO

EXEC sp_addextendedproperty
'MS_Description', N'主键Id',
'SCHEMA', N'dbo',
'TABLE', N'Consumer',
'COLUMN', N'Id'
GO

EXEC sp_addextendedproperty
'MS_Description', N'客户名称',
'SCHEMA', N'dbo',
'TABLE', N'Consumer',
'COLUMN', N'CustomerName'
GO

EXEC sp_addextendedproperty
'MS_Description', N'联系人',
'SCHEMA', N'dbo',
'TABLE', N'Consumer',
'COLUMN', N'Contact'
GO

EXEC sp_addextendedproperty
'MS_Description', N'联系电话',
'SCHEMA', N'dbo',
'TABLE', N'Consumer',
'COLUMN', N'Phone'
GO

EXEC sp_addextendedproperty
'MS_Description', N'创建时间',
'SCHEMA', N'dbo',
'TABLE', N'Consumer',
'COLUMN', N'CreateTime'
GO

EXEC sp_addextendedproperty
'MS_Description', N'创建人',
'SCHEMA', N'dbo',
'TABLE', N'Consumer',
'COLUMN', N'CreateName'
GO

EXEC sp_addextendedproperty
'MS_Description', N'是否删除(0否,99是)',
'SCHEMA', N'dbo',
'TABLE', N'Consumer',
'COLUMN', N'IsDelete'
GO


-- ----------------------------
-- Records of Consumer
-- ----------------------------
INSERT INTO [dbo].[Consumer] ([Id], [CustomerName], [Contact], [Phone], [CreateTime], [CreateName], [IsDelete]) VALUES (N'2f2cda91-c7f6-4e92-9dd7-552bc0782595', N'第三方发给对方过后', N'但是价格优惠', N'aaaa', N'2024-05-11 16:15:15.683', N'鼓腹含和', N'0')
GO

INSERT INTO [dbo].[Consumer] ([Id], [CustomerName], [Contact], [Phone], [CreateTime], [CreateName], [IsDelete]) VALUES (N'41de9bd0-f7b7-40c8-a988-fe22e33d0e77', N'第三方发给重新', N'给对方都是', N'给对方', N'2024-05-11 16:35:22.917', N'鼓腹含和', N'0')
GO

INSERT INTO [dbo].[Consumer] ([Id], [CustomerName], [Contact], [Phone], [CreateTime], [CreateName], [IsDelete]) VALUES (N'6e73a9af-2788-4e5c-ad04-e26599671b76', N'第收到复活甲', N'噼噼啪啪', N'即可红烧豆腐', N'2024-05-11 16:15:13.273', N'的过程的', N'0')
GO

INSERT INTO [dbo].[Consumer] ([Id], [CustomerName], [Contact], [Phone], [CreateTime], [CreateName], [IsDelete]) VALUES (N'8e21fe34-2a29-4f02-bab8-f5c2429e2566', N'', N'', N'', N'2024-05-11 16:45:06.173', N'', N'99')
GO

INSERT INTO [dbo].[Consumer] ([Id], [CustomerName], [Contact], [Phone], [CreateTime], [CreateName], [IsDelete]) VALUES (N'df9d67a1-6c4c-4196-bfd6-3bbb49366f29', N'发发发刚刚好', N'噼噼啪啪', N'即可红烧豆腐', N'2024-05-13 13:47:47.370', N'地方根本大法', N'0')
GO

INSERT INTO [dbo].[Consumer] ([Id], [CustomerName], [Contact], [Phone], [CreateTime], [CreateName], [IsDelete]) VALUES (N'e40e6171-e383-4378-9e4f-eef876a80c21', N'第三方', N'给对方', N'给对方', N'2024-05-11 16:11:43.950', N'鼓腹含和', N'0')
GO

INSERT INTO [dbo].[Consumer] ([Id], [CustomerName], [Contact], [Phone], [CreateTime], [CreateName], [IsDelete]) VALUES (N'eb4e9aa8-c401-47a3-b9d8-a42277819fdf', N'第三方发给', N'给对方都是', N'给对方', N'2024-05-11 16:15:11.307', N'鼓腹含和', N'0')
GO

INSERT INTO [dbo].[Consumer] ([Id], [CustomerName], [Contact], [Phone], [CreateTime], [CreateName], [IsDelete]) VALUES (N'hfjds', N'记录电话费', N'监考老师电话费', N'0486433', N'2024-05-11 15:53:42.000', N'多个地方', N'0')
GO


-- ----------------------------
-- Table structure for MajorIngredient
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[MajorIngredient]') AND type IN ('U'))
	DROP TABLE [dbo].[MajorIngredient]
GO

CREATE TABLE [dbo].[MajorIngredient] (
  [Id] varchar(255) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [MainName] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [Unit] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [CreateTime] datetime  NULL,
  [CreateName] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [IsDelete] int  NULL
)
GO

ALTER TABLE [dbo].[MajorIngredient] SET (LOCK_ESCALATION = TABLE)
GO

EXEC sp_addextendedproperty
'MS_Description', N'主键Id',
'SCHEMA', N'dbo',
'TABLE', N'MajorIngredient',
'COLUMN', N'Id'
GO

EXEC sp_addextendedproperty
'MS_Description', N'主料名称',
'SCHEMA', N'dbo',
'TABLE', N'MajorIngredient',
'COLUMN', N'MainName'
GO

EXEC sp_addextendedproperty
'MS_Description', N'单位',
'SCHEMA', N'dbo',
'TABLE', N'MajorIngredient',
'COLUMN', N'Unit'
GO

EXEC sp_addextendedproperty
'MS_Description', N'创建时间',
'SCHEMA', N'dbo',
'TABLE', N'MajorIngredient',
'COLUMN', N'CreateTime'
GO

EXEC sp_addextendedproperty
'MS_Description', N'创建人',
'SCHEMA', N'dbo',
'TABLE', N'MajorIngredient',
'COLUMN', N'CreateName'
GO

EXEC sp_addextendedproperty
'MS_Description', N'是否删除(0否,99是)',
'SCHEMA', N'dbo',
'TABLE', N'MajorIngredient',
'COLUMN', N'IsDelete'
GO


-- ----------------------------
-- Records of MajorIngredient
-- ----------------------------
INSERT INTO [dbo].[MajorIngredient] ([Id], [MainName], [Unit], [CreateTime], [CreateName], [IsDelete]) VALUES (N'12cc9724-e185-4634-a95c-4adac5566e95', N'主料6666', N'单位666', N'2024-05-07 11:42:24.570', N'大力', N'0')
GO

INSERT INTO [dbo].[MajorIngredient] ([Id], [MainName], [Unit], [CreateTime], [CreateName], [IsDelete]) VALUES (N'88c78f44-1e6d-49d9-b552-f61c2c0f71ec', N'水电费', N'放到', N'2024-05-09 15:02:24.680', N'电饭锅', N'0')
GO

INSERT INTO [dbo].[MajorIngredient] ([Id], [MainName], [Unit], [CreateTime], [CreateName], [IsDelete]) VALUES (N'ca6f2c53-be57-49d8-92be-f84da725e0d9', N'主料电饭锅的', N'克', N'2024-05-09 14:59:38.413', N'都是', N'0')
GO


-- ----------------------------
-- Table structure for OrderSupplement
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[OrderSupplement]') AND type IN ('U'))
	DROP TABLE [dbo].[OrderSupplement]
GO

CREATE TABLE [dbo].[OrderSupplement] (
  [Id] varchar(255) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [AdditionalRecording] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [CreateTime] datetime  NULL,
  [CreateName] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [IsDelete] int  NULL
)
GO

ALTER TABLE [dbo].[OrderSupplement] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of OrderSupplement
-- ----------------------------
INSERT INTO [dbo].[OrderSupplement] ([Id], [AdditionalRecording], [CreateTime], [CreateName], [IsDelete]) VALUES (N'15377545-f093-4c6d-b4bd-aa1afa5f38b6', N' 第三方v', N'2024-05-13 15:35:44.520', N'', N'0')
GO

INSERT INTO [dbo].[OrderSupplement] ([Id], [AdditionalRecording], [CreateTime], [CreateName], [IsDelete]) VALUES (N'29a3567a-be86-4d76-8c34-b5de4a732c72', N' 第三方v地方', N'2024-05-13 16:38:31.863', N'好好好', N'0')
GO

INSERT INTO [dbo].[OrderSupplement] ([Id], [AdditionalRecording], [CreateTime], [CreateName], [IsDelete]) VALUES (N'3ada3066-b97d-46c5-b3a1-bbb58a1fc665', N'电饭锅', N'2024-05-13 15:36:25.713', N'', N'99')
GO

INSERT INTO [dbo].[OrderSupplement] ([Id], [AdditionalRecording], [CreateTime], [CreateName], [IsDelete]) VALUES (N'3e9d3b8f-3e55-4a8d-940a-7a95acf22d80', N'GGG', N'2024-05-13 15:40:31.157', N'', N'0')
GO

INSERT INTO [dbo].[OrderSupplement] ([Id], [AdditionalRecording], [CreateTime], [CreateName], [IsDelete]) VALUES (N'521f54af-d057-4b81-a7b5-ec297c5f0e15', N'地方', N'2024-05-13 15:37:07.077', N'黑寡妇', N'99')
GO

INSERT INTO [dbo].[OrderSupplement] ([Id], [AdditionalRecording], [CreateTime], [CreateName], [IsDelete]) VALUES (N'912d0801-c3fe-4d8b-891d-b7db6c6c8d4c', N'相差官方', N'2024-05-13 15:37:02.913', N'', N'99')
GO

INSERT INTO [dbo].[OrderSupplement] ([Id], [AdditionalRecording], [CreateTime], [CreateName], [IsDelete]) VALUES (N'd437b0ff-085c-4e32-aa0c-5d64d66d7977', N' 第三方v地方', N'2024-05-13 16:38:28.123', N'', N'0')
GO

INSERT INTO [dbo].[OrderSupplement] ([Id], [AdditionalRecording], [CreateTime], [CreateName], [IsDelete]) VALUES (N'de5074d3-f285-4695-84fe-0c9428b10b53', N' 第三方v', N'2024-05-13 15:40:21.850', N'', N'0')
GO

INSERT INTO [dbo].[OrderSupplement] ([Id], [AdditionalRecording], [CreateTime], [CreateName], [IsDelete]) VALUES (N'e41274e3-7f5a-4e5f-b19c-e2cb56289965', N' 第三方v地方', N'2024-05-15 16:09:42.177', N'大力', N'0')
GO

INSERT INTO [dbo].[OrderSupplement] ([Id], [AdditionalRecording], [CreateTime], [CreateName], [IsDelete]) VALUES (N'e876ba1e-0d2a-4e7e-a0df-113d572c7fe4', N'好吃输入法', N'2024-05-13 15:36:59.440', N'', N'99')
GO


-- ----------------------------
-- Table structure for OutboundManager
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[OutboundManager]') AND type IN ('U'))
	DROP TABLE [dbo].[OutboundManager]
GO

CREATE TABLE [dbo].[OutboundManager] (
  [Id] varchar(255) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [OutboundName] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [Contact] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [Phone] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [CreateTime] datetime  NULL,
  [CreateName] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [IsDelete] int  NULL
)
GO

ALTER TABLE [dbo].[OutboundManager] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of OutboundManager
-- ----------------------------
INSERT INTO [dbo].[OutboundManager] ([Id], [OutboundName], [Contact], [Phone], [CreateTime], [CreateName], [IsDelete]) VALUES (N'6de5a0bd-876a-4994-9408-111a8b404f88', N'都是哈哈哈哈', N'给对方好好好', N'对方过后', N'2024-05-13 13:47:04.667', N'2024/5/13 13:46:47', N'0')
GO

INSERT INTO [dbo].[OutboundManager] ([Id], [OutboundName], [Contact], [Phone], [CreateTime], [CreateName], [IsDelete]) VALUES (N'8e964e71-76e5-43a9-98be-e7dc64aeade5', N'都是', N'给对方', N'对方过后', N'2024-05-13 14:01:33.513', N'88888', N'0')
GO

INSERT INTO [dbo].[OutboundManager] ([Id], [OutboundName], [Contact], [Phone], [CreateTime], [CreateName], [IsDelete]) VALUES (N'b86e9b92-5050-4e7f-990d-44312d297581', N'都是', N'给对方', N'对方过后', N'2024-05-13 13:46:49.530', N'2024/5/13 13:46:47', N'0')
GO

INSERT INTO [dbo].[OutboundManager] ([Id], [OutboundName], [Contact], [Phone], [CreateTime], [CreateName], [IsDelete]) VALUES (N'cee79fd4-4b72-4b9e-a40d-35a9ff1c3441', N'第三方', N'放到', N'梵蒂冈', N'2024-05-13 13:47:55.960', N'梵蒂冈', N'0')
GO

INSERT INTO [dbo].[OutboundManager] ([Id], [OutboundName], [Contact], [Phone], [CreateTime], [CreateName], [IsDelete]) VALUES (N'd8347651-419a-4c00-9794-8edc264633ce', N'', N'', N'', N'2024-05-13 13:46:42.590', N'', N'99')
GO

INSERT INTO [dbo].[OutboundManager] ([Id], [OutboundName], [Contact], [Phone], [CreateTime], [CreateName], [IsDelete]) VALUES (N'e6940340-52b4-4f6a-84b7-efe90213931c', N'都是', N'给对方', N'对方过后', N'2024-05-13 13:46:47.723', N'地方', N'0')
GO

INSERT INTO [dbo].[OutboundManager] ([Id], [OutboundName], [Contact], [Phone], [CreateTime], [CreateName], [IsDelete]) VALUES (N'fe1c4c6a-e59c-413c-a1d3-7e6d6941a37b', N'都是', N'给对方', N'对方过后', N'2024-05-13 14:01:28.763', N'2024/5/13 13:46:49', N'0')
GO


-- ----------------------------
-- Table structure for PermSetting
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[PermSetting]') AND type IN ('U'))
	DROP TABLE [dbo].[PermSetting]
GO

CREATE TABLE [dbo].[PermSetting] (
  [Id] varchar(255) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [PermName] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [PermSpecifications] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [CreateTime] datetime  NULL,
  [CreateName] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [IsDelete] int  NULL
)
GO

ALTER TABLE [dbo].[PermSetting] SET (LOCK_ESCALATION = TABLE)
GO

EXEC sp_addextendedproperty
'MS_Description', N'主键Id',
'SCHEMA', N'dbo',
'TABLE', N'PermSetting',
'COLUMN', N'Id'
GO

EXEC sp_addextendedproperty
'MS_Description', N'烫头名称',
'SCHEMA', N'dbo',
'TABLE', N'PermSetting',
'COLUMN', N'PermName'
GO

EXEC sp_addextendedproperty
'MS_Description', N'烫头规格',
'SCHEMA', N'dbo',
'TABLE', N'PermSetting',
'COLUMN', N'PermSpecifications'
GO

EXEC sp_addextendedproperty
'MS_Description', N'创建时间',
'SCHEMA', N'dbo',
'TABLE', N'PermSetting',
'COLUMN', N'CreateTime'
GO

EXEC sp_addextendedproperty
'MS_Description', N'创建人名称',
'SCHEMA', N'dbo',
'TABLE', N'PermSetting',
'COLUMN', N'CreateName'
GO

EXEC sp_addextendedproperty
'MS_Description', N'是否删除(0否,99是)',
'SCHEMA', N'dbo',
'TABLE', N'PermSetting',
'COLUMN', N'IsDelete'
GO


-- ----------------------------
-- Records of PermSetting
-- ----------------------------
INSERT INTO [dbo].[PermSetting] ([Id], [PermName], [PermSpecifications], [CreateTime], [CreateName], [IsDelete]) VALUES (N'06e424db-3256-4415-8355-84318a397762', N'森岛帆高见客户', N'二号机京东方试试', N'2024-05-07 09:06:56.937', N'大力', N'0')
GO

INSERT INTO [dbo].[PermSetting] ([Id], [PermName], [PermSpecifications], [CreateTime], [CreateName], [IsDelete]) VALUES (N'0e3b8f7d-cf99-49e7-9d6b-2d5e060ff230', N'森岛帆高见客户', N'二号机京东方试试', N'2024-05-06 15:39:04.797', N'大力', N'0')
GO

INSERT INTO [dbo].[PermSetting] ([Id], [PermName], [PermSpecifications], [CreateTime], [CreateName], [IsDelete]) VALUES (N'235e651f-f043-4c3a-82ac-2c3cf2a83b75', N'都是对的', N'灌灌灌灌', N'2024-05-06 15:55:56.897', N'', N'99')
GO

INSERT INTO [dbo].[PermSetting] ([Id], [PermName], [PermSpecifications], [CreateTime], [CreateName], [IsDelete]) VALUES (N'2713bada-13d7-41f9-b3de-4f2f56819c68', N'烫头A001', N'规格A001', N'2024-05-16 10:42:53.783', N'大力', N'0')
GO

INSERT INTO [dbo].[PermSetting] ([Id], [PermName], [PermSpecifications], [CreateTime], [CreateName], [IsDelete]) VALUES (N'2a3c29a7-9e53-4fdf-8a56-4f23f78a19a2', N'111', N'3433', N'2024-05-06 15:38:08.327', N'', N'99')
GO

INSERT INTO [dbo].[PermSetting] ([Id], [PermName], [PermSpecifications], [CreateTime], [CreateName], [IsDelete]) VALUES (N'7fa28e58-7d7f-4226-8fbd-0464771ce342', N'2333的', N'333放到', N'2024-05-06 15:39:48.793', N'大力', N'99')
GO

INSERT INTO [dbo].[PermSetting] ([Id], [PermName], [PermSpecifications], [CreateTime], [CreateName], [IsDelete]) VALUES (N'fe9c7c59-af7d-45a0-89a0-3468d2d3756b', N'第三方', N'发的鬼地方', N'2024-05-06 15:55:52.913', N'', N'0')
GO


-- ----------------------------
-- Table structure for ProcessSetting
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[ProcessSetting]') AND type IN ('U'))
	DROP TABLE [dbo].[ProcessSetting]
GO

CREATE TABLE [dbo].[ProcessSetting] (
  [Id] varchar(255) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [ProcessName] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [Main] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [Accessory] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [CreateTime] datetime2(7)  NULL,
  [CreateName] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [IsDelete] int  NULL,
  [Price] decimal(18,2)  NULL
)
GO

ALTER TABLE [dbo].[ProcessSetting] SET (LOCK_ESCALATION = TABLE)
GO

EXEC sp_addextendedproperty
'MS_Description', N'主键Id',
'SCHEMA', N'dbo',
'TABLE', N'ProcessSetting',
'COLUMN', N'Id'
GO

EXEC sp_addextendedproperty
'MS_Description', N'工艺名称',
'SCHEMA', N'dbo',
'TABLE', N'ProcessSetting',
'COLUMN', N'ProcessName'
GO

EXEC sp_addextendedproperty
'MS_Description', N'主料',
'SCHEMA', N'dbo',
'TABLE', N'ProcessSetting',
'COLUMN', N'Main'
GO

EXEC sp_addextendedproperty
'MS_Description', N'辅料',
'SCHEMA', N'dbo',
'TABLE', N'ProcessSetting',
'COLUMN', N'Accessory'
GO

EXEC sp_addextendedproperty
'MS_Description', N'创建时间',
'SCHEMA', N'dbo',
'TABLE', N'ProcessSetting',
'COLUMN', N'CreateTime'
GO

EXEC sp_addextendedproperty
'MS_Description', N'创建人',
'SCHEMA', N'dbo',
'TABLE', N'ProcessSetting',
'COLUMN', N'CreateName'
GO

EXEC sp_addextendedproperty
'MS_Description', N'是否删除(0否,99是)',
'SCHEMA', N'dbo',
'TABLE', N'ProcessSetting',
'COLUMN', N'IsDelete'
GO

EXEC sp_addextendedproperty
'MS_Description', N'工艺价格',
'SCHEMA', N'dbo',
'TABLE', N'ProcessSetting',
'COLUMN', N'Price'
GO


-- ----------------------------
-- Records of ProcessSetting
-- ----------------------------
INSERT INTO [dbo].[ProcessSetting] ([Id], [ProcessName], [Main], [Accessory], [CreateTime], [CreateName], [IsDelete], [Price]) VALUES (N'5923498a-16dc-489e-ab09-b7c6ce3aab84', N'第三方', N'主料5; 主料7; 主料10; ', N'辅料3; 辅料5; 辅料8; ', N'2024-05-08 16:29:39.6513694', N'法国德国好家伙', N'99', N'3.00')
GO

INSERT INTO [dbo].[ProcessSetting] ([Id], [ProcessName], [Main], [Accessory], [CreateTime], [CreateName], [IsDelete], [Price]) VALUES (N'5be0e9cf-6e0a-469d-b2c2-8191caae55f8', N'水电费', N'主料1; 主料2; 主料3; ', N'辅料1; 辅料3; 辅料4; ', N'2024-05-08 15:53:30.7000622', N'电饭锅', N'99', N'3.00')
GO

INSERT INTO [dbo].[ProcessSetting] ([Id], [ProcessName], [Main], [Accessory], [CreateTime], [CreateName], [IsDelete], [Price]) VALUES (N'6d14c05c-58d4-4d10-b8f1-e727acfb1815', N'给577', N'主料6666; 主料电饭锅的; ', N'辅料名称222; 豆腐干地方; 豆腐干地方; 豆腐干地方; 豆腐干地方; 辅料名称222; ', N'2024-05-08 15:50:27.8604404', N'电饭锅', N'0', N'3.00')
GO

INSERT INTO [dbo].[ProcessSetting] ([Id], [ProcessName], [Main], [Accessory], [CreateTime], [CreateName], [IsDelete], [Price]) VALUES (N'74fdc10c-ee71-4e63-b0ab-1f255d16402f', N'水电费', N'主料6666; ', N'豆腐干地方;  顶顶顶; 的发射点; 收到覅收到货; 辅料名称222; ', N'2024-05-08 16:35:57.5086144', N'电饭锅', N'0', N'4.00')
GO

INSERT INTO [dbo].[ProcessSetting] ([Id], [ProcessName], [Main], [Accessory], [CreateTime], [CreateName], [IsDelete], [Price]) VALUES (N'91ee6782-68c5-4dcc-ad6c-cc8869ff3ccf', N'水电费222', N'主料6666; 水电费; 主料电饭锅的; ', N'收到覅收到货; 辅料名称222; 豆腐干地方; 豆腐干地方第三方;  顶顶顶方法; ', N'2024-05-08 16:29:27.6625694', N'电饭锅', N'0', N'4443.00')
GO

INSERT INTO [dbo].[ProcessSetting] ([Id], [ProcessName], [Main], [Accessory], [CreateTime], [CreateName], [IsDelete], [Price]) VALUES (N'ab426626-5775-4f66-ab6f-41f1dc096138', N'水电费434534', N'主料6666; ', N'辅料名称222232; ', N'2024-05-08 16:35:59.2785430', N'电饭锅', N'0', N'3.08')
GO

INSERT INTO [dbo].[ProcessSetting] ([Id], [ProcessName], [Main], [Accessory], [CreateTime], [CreateName], [IsDelete], [Price]) VALUES (N'bc5e0b43-f204-47f3-a589-5996360b2421', N'水电费22222', N'第三方都是', N'辅料1; 辅料2; 辅料3; 辅料4; ', N'2024-05-08 16:11:09.3344987', N'电饭锅', N'99', N'3.00')
GO

INSERT INTO [dbo].[ProcessSetting] ([Id], [ProcessName], [Main], [Accessory], [CreateTime], [CreateName], [IsDelete], [Price]) VALUES (N'cca939cd-16b7-41db-ab22-161f71e7104d', N'水电费434534', N'主料6666; ', N'豆腐干地方; 辅料名称222232; 豆腐干地方;  顶顶顶; ', N'2024-05-09 14:57:29.9257427', N'电饭锅', N'0', N'3.08')
GO

INSERT INTO [dbo].[ProcessSetting] ([Id], [ProcessName], [Main], [Accessory], [CreateTime], [CreateName], [IsDelete], [Price]) VALUES (N'df', N'水电费', N'第三方都是', N'递四方速递', N'2024-05-08 15:25:36.0000000', N'电饭锅', N'99', N'3.00')
GO

INSERT INTO [dbo].[ProcessSetting] ([Id], [ProcessName], [Main], [Accessory], [CreateTime], [CreateName], [IsDelete], [Price]) VALUES (N'f158e45d-e06c-49e4-8aeb-5acb498b1d8e', N'888', N'主料6666; 水电费; 主料电饭锅的; ', N'收到覅收到货; 辅料名称222; 豆腐干地方; ', N'2024-05-16 10:47:32.8452132', N'大力', N'0', N'0.00')
GO


-- ----------------------------
-- Table structure for ProductSetup
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[ProductSetup]') AND type IN ('U'))
	DROP TABLE [dbo].[ProductSetup]
GO

CREATE TABLE [dbo].[ProductSetup] (
  [Id] varchar(255) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [ProductName] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [ProcessName] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [Price] decimal(18,2)  NULL,
  [CreateTime] datetime2(7)  NULL,
  [CreateName] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [IsDelete] int  NULL
)
GO

ALTER TABLE [dbo].[ProductSetup] SET (LOCK_ESCALATION = TABLE)
GO

EXEC sp_addextendedproperty
'MS_Description', N'主键',
'SCHEMA', N'dbo',
'TABLE', N'ProductSetup',
'COLUMN', N'Id'
GO

EXEC sp_addextendedproperty
'MS_Description', N'产品名称',
'SCHEMA', N'dbo',
'TABLE', N'ProductSetup',
'COLUMN', N'ProductName'
GO

EXEC sp_addextendedproperty
'MS_Description', N'工艺名称',
'SCHEMA', N'dbo',
'TABLE', N'ProductSetup',
'COLUMN', N'ProcessName'
GO

EXEC sp_addextendedproperty
'MS_Description', N'价格',
'SCHEMA', N'dbo',
'TABLE', N'ProductSetup',
'COLUMN', N'Price'
GO

EXEC sp_addextendedproperty
'MS_Description', N'创建时间',
'SCHEMA', N'dbo',
'TABLE', N'ProductSetup',
'COLUMN', N'CreateTime'
GO

EXEC sp_addextendedproperty
'MS_Description', N'创建人',
'SCHEMA', N'dbo',
'TABLE', N'ProductSetup',
'COLUMN', N'CreateName'
GO

EXEC sp_addextendedproperty
'MS_Description', N'是否删除(0否,99是)',
'SCHEMA', N'dbo',
'TABLE', N'ProductSetup',
'COLUMN', N'IsDelete'
GO


-- ----------------------------
-- Records of ProductSetup
-- ----------------------------
INSERT INTO [dbo].[ProductSetup] ([Id], [ProductName], [ProcessName], [Price], [CreateTime], [CreateName], [IsDelete]) VALUES (N'75f88957-808c-4f18-96d9-03c8f7513283', N'产品名称001', N'水电费;水电费222;水电费434534;', N'4450.08', N'2024-05-09 11:53:17.0423011', N'大力', N'0')
GO

INSERT INTO [dbo].[ProductSetup] ([Id], [ProductName], [ProcessName], [Price], [CreateTime], [CreateName], [IsDelete]) VALUES (N'a09990cd-a79f-4aa5-9576-f27bddf28a82', N'工艺名称1', N'水电费;水电费222;', N'4447.00', N'2024-05-09 11:53:00.7445583', N'大力', N'0')
GO

INSERT INTO [dbo].[ProductSetup] ([Id], [ProductName], [ProcessName], [Price], [CreateTime], [CreateName], [IsDelete]) VALUES (N'af7f49ac-f5dd-4e0b-b052-3167459ca394', N'产品名称001', N'水电费;', N'4.00', N'2024-05-09 13:09:53.0578934', N'大力', N'99')
GO

INSERT INTO [dbo].[ProductSetup] ([Id], [ProductName], [ProcessName], [Price], [CreateTime], [CreateName], [IsDelete]) VALUES (N'd1b6b901-c0e5-4f38-92c4-2e59c0363017', N'产品名称001', N'给577;水电费;水电费222;水电费434534;水电费434534;', N'4456.16', N'2024-05-09 13:09:46.5081719', N'大力', N'0')
GO

INSERT INTO [dbo].[ProductSetup] ([Id], [ProductName], [ProcessName], [Price], [CreateTime], [CreateName], [IsDelete]) VALUES (N'dsf`', N'工艺名称1', N'水电费', N'18.88', N'2024-05-09 09:16:20.0000000', N'大力', N'0')
GO


-- ----------------------------
-- Table structure for SpecificationSetting
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[SpecificationSetting]') AND type IN ('U'))
	DROP TABLE [dbo].[SpecificationSetting]
GO

CREATE TABLE [dbo].[SpecificationSetting] (
  [Id] varchar(255) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [NameOfTheMaterial] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [Unit] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [LengthUnit] decimal(18,2)  NULL,
  [CreateTime] datetime  NULL,
  [CreateName] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [IsDelete] int  NULL
)
GO

ALTER TABLE [dbo].[SpecificationSetting] SET (LOCK_ESCALATION = TABLE)
GO

EXEC sp_addextendedproperty
'MS_Description', N'主键Id',
'SCHEMA', N'dbo',
'TABLE', N'SpecificationSetting',
'COLUMN', N'Id'
GO

EXEC sp_addextendedproperty
'MS_Description', N'材料名称',
'SCHEMA', N'dbo',
'TABLE', N'SpecificationSetting',
'COLUMN', N'NameOfTheMaterial'
GO

EXEC sp_addextendedproperty
'MS_Description', N'单位',
'SCHEMA', N'dbo',
'TABLE', N'SpecificationSetting',
'COLUMN', N'Unit'
GO

EXEC sp_addextendedproperty
'MS_Description', N'长度',
'SCHEMA', N'dbo',
'TABLE', N'SpecificationSetting',
'COLUMN', N'LengthUnit'
GO

EXEC sp_addextendedproperty
'MS_Description', N'是',
'SCHEMA', N'dbo',
'TABLE', N'SpecificationSetting',
'COLUMN', N'CreateTime'
GO

EXEC sp_addextendedproperty
'MS_Description', N'创建人 ',
'SCHEMA', N'dbo',
'TABLE', N'SpecificationSetting',
'COLUMN', N'CreateName'
GO

EXEC sp_addextendedproperty
'MS_Description', N'是否删除(0否,99是)',
'SCHEMA', N'dbo',
'TABLE', N'SpecificationSetting',
'COLUMN', N'IsDelete'
GO


-- ----------------------------
-- Records of SpecificationSetting
-- ----------------------------
INSERT INTO [dbo].[SpecificationSetting] ([Id], [NameOfTheMaterial], [Unit], [LengthUnit], [CreateTime], [CreateName], [IsDelete]) VALUES (N'282a323e-84a6-4ae4-ac77-0ef43e41be4a', N'测试收到覅', N'尺', N'6.78', N'2024-05-11 11:25:12.483', N'大力对对对', N'0')
GO

INSERT INTO [dbo].[SpecificationSetting] ([Id], [NameOfTheMaterial], [Unit], [LengthUnit], [CreateTime], [CreateName], [IsDelete]) VALUES (N'473bfccb-416c-457a-ad00-83feef5c660c', N'测试材料名称', N'卷', N'1.33', N'2024-05-11 11:16:20.403', N'大力', N'99')
GO

INSERT INTO [dbo].[SpecificationSetting] ([Id], [NameOfTheMaterial], [Unit], [LengthUnit], [CreateTime], [CreateName], [IsDelete]) VALUES (N'f589857b-8a46-4a5b-9dae-3f8e3638aa88', N'测试材料名称', N'卷', N'1.33', N'2024-05-11 11:25:14.917', N'大力', N'0')
GO


-- ----------------------------
-- Table structure for Stocks
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Stocks]') AND type IN ('U'))
	DROP TABLE [dbo].[Stocks]
GO

CREATE TABLE [dbo].[Stocks] (
  [Id] varchar(255) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [NameOfMaterial] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [QuantityOfMaterial] int  NULL,
  [CreateTime] datetime  NULL,
  [CreateName] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [IsDelete] int  NULL
)
GO

ALTER TABLE [dbo].[Stocks] SET (LOCK_ESCALATION = TABLE)
GO

EXEC sp_addextendedproperty
'MS_Description', N'主键Id',
'SCHEMA', N'dbo',
'TABLE', N'Stocks',
'COLUMN', N'Id'
GO

EXEC sp_addextendedproperty
'MS_Description', N'物料名称',
'SCHEMA', N'dbo',
'TABLE', N'Stocks',
'COLUMN', N'NameOfMaterial'
GO

EXEC sp_addextendedproperty
'MS_Description', N'物料数量',
'SCHEMA', N'dbo',
'TABLE', N'Stocks',
'COLUMN', N'QuantityOfMaterial'
GO

EXEC sp_addextendedproperty
'MS_Description', N'创建时间',
'SCHEMA', N'dbo',
'TABLE', N'Stocks',
'COLUMN', N'CreateTime'
GO

EXEC sp_addextendedproperty
'MS_Description', N'创建人',
'SCHEMA', N'dbo',
'TABLE', N'Stocks',
'COLUMN', N'CreateName'
GO

EXEC sp_addextendedproperty
'MS_Description', N'是否删除(0否,99是)',
'SCHEMA', N'dbo',
'TABLE', N'Stocks',
'COLUMN', N'IsDelete'
GO


-- ----------------------------
-- Records of Stocks
-- ----------------------------
INSERT INTO [dbo].[Stocks] ([Id], [NameOfMaterial], [QuantityOfMaterial], [CreateTime], [CreateName], [IsDelete]) VALUES (N'53aec262-6e0a-450f-a66f-4b2aa85a61dc', N'测试水电费发发发', N'10000', N'2024-05-13 09:53:07.493', N'创建人', N'0')
GO

INSERT INTO [dbo].[Stocks] ([Id], [NameOfMaterial], [QuantityOfMaterial], [CreateTime], [CreateName], [IsDelete]) VALUES (N'55f97741-758f-449d-b8c8-28330e89077f', N'测试水电费', N'1456677', N'2024-05-13 09:53:00.020', N'创建人', N'0')
GO

INSERT INTO [dbo].[Stocks] ([Id], [NameOfMaterial], [QuantityOfMaterial], [CreateTime], [CreateName], [IsDelete]) VALUES (N'de0a00b7-10a1-475a-a5c4-6217636f7672', N'发生的饭费', N'111', N'2024-05-13 09:49:14.913', N'创建人', N'0')
GO

INSERT INTO [dbo].[Stocks] ([Id], [NameOfMaterial], [QuantityOfMaterial], [CreateTime], [CreateName], [IsDelete]) VALUES (N'dsfsd', N'测试', N'1', N'2024-05-13 09:42:56.000', N'3', N'0')
GO


-- ----------------------------
-- Table structure for SupplierName
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[SupplierName]') AND type IN ('U'))
	DROP TABLE [dbo].[SupplierName]
GO

CREATE TABLE [dbo].[SupplierName] (
  [Id] varchar(255) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [NameOfTheSupplier] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [SuppliersList] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [SupplyPosition] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [Price] decimal(18,2)  NULL,
  [CreateTime] datetime  NULL,
  [CreateName] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [IsDelete] int  NULL
)
GO

ALTER TABLE [dbo].[SupplierName] SET (LOCK_ESCALATION = TABLE)
GO

EXEC sp_addextendedproperty
'MS_Description', N'主键Id',
'SCHEMA', N'dbo',
'TABLE', N'SupplierName',
'COLUMN', N'Id'
GO

EXEC sp_addextendedproperty
'MS_Description', N'供应商名称',
'SCHEMA', N'dbo',
'TABLE', N'SupplierName',
'COLUMN', N'NameOfTheSupplier'
GO

EXEC sp_addextendedproperty
'MS_Description', N'供应商信息',
'SCHEMA', N'dbo',
'TABLE', N'SupplierName',
'COLUMN', N'SuppliersList'
GO

EXEC sp_addextendedproperty
'MS_Description', N'供货情况',
'SCHEMA', N'dbo',
'TABLE', N'SupplierName',
'COLUMN', N'SupplyPosition'
GO

EXEC sp_addextendedproperty
'MS_Description', N'货物单价',
'SCHEMA', N'dbo',
'TABLE', N'SupplierName',
'COLUMN', N'Price'
GO

EXEC sp_addextendedproperty
'MS_Description', N'创建时间',
'SCHEMA', N'dbo',
'TABLE', N'SupplierName',
'COLUMN', N'CreateTime'
GO

EXEC sp_addextendedproperty
'MS_Description', N'创建人',
'SCHEMA', N'dbo',
'TABLE', N'SupplierName',
'COLUMN', N'CreateName'
GO

EXEC sp_addextendedproperty
'MS_Description', N'是否删除(0否,99是)',
'SCHEMA', N'dbo',
'TABLE', N'SupplierName',
'COLUMN', N'IsDelete'
GO


-- ----------------------------
-- Records of SupplierName
-- ----------------------------
INSERT INTO [dbo].[SupplierName] ([Id], [NameOfTheSupplier], [SuppliersList], [SupplyPosition], [Price], [CreateTime], [CreateName], [IsDelete]) VALUES (N'58f5666d-2720-444b-bca3-a141efca0323', N'供应7867', N'信息66334', N'发过火电饭锅更好地方', N'110.00', N'2024-05-11 14:01:49.130', N'大力', N'99')
GO

INSERT INTO [dbo].[SupplierName] ([Id], [NameOfTheSupplier], [SuppliersList], [SupplyPosition], [Price], [CreateTime], [CreateName], [IsDelete]) VALUES (N'5c3f14fb-9dc8-4948-bfab-8ed5d22cc3e1', N'供应7867', N'信息66334', N'发过火电饭锅更好地方', N'110.00', N'2024-05-11 14:01:46.677', N'大力', N'0')
GO

INSERT INTO [dbo].[SupplierName] ([Id], [NameOfTheSupplier], [SuppliersList], [SupplyPosition], [Price], [CreateTime], [CreateName], [IsDelete]) VALUES (N'838101d9-1274-4a69-88a2-593db655c50e', N'供应7867收到', N'信息66334vv', N'发过火电饭锅更好地方', N'110.00', N'2024-05-11 15:59:21.513', N'大力', N'0')
GO

INSERT INTO [dbo].[SupplierName] ([Id], [NameOfTheSupplier], [SuppliersList], [SupplyPosition], [Price], [CreateTime], [CreateName], [IsDelete]) VALUES (N'c6ec2154-07a8-44af-9bb2-8a1bed211a53', N'供应7867', N'信息66334vv', N'发过火电饭锅更好地方', N'110.00', N'2024-05-11 14:08:09.527', N'大力', N'0')
GO


-- ----------------------------
-- Table structure for Sys_Menu
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Sys_Menu]') AND type IN ('U'))
	DROP TABLE [dbo].[Sys_Menu]
GO

CREATE TABLE [dbo].[Sys_Menu] (
  [Id] varchar(255) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [MenuText] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [CreateTime] datetime  NULL,
  [Sort] int  NULL,
  [Icon] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL
)
GO

ALTER TABLE [dbo].[Sys_Menu] SET (LOCK_ESCALATION = TABLE)
GO

EXEC sp_addextendedproperty
'MS_Description', N'主键Id',
'SCHEMA', N'dbo',
'TABLE', N'Sys_Menu',
'COLUMN', N'Id'
GO

EXEC sp_addextendedproperty
'MS_Description', N'菜单名称',
'SCHEMA', N'dbo',
'TABLE', N'Sys_Menu',
'COLUMN', N'MenuText'
GO

EXEC sp_addextendedproperty
'MS_Description', N'创建时间',
'SCHEMA', N'dbo',
'TABLE', N'Sys_Menu',
'COLUMN', N'CreateTime'
GO

EXEC sp_addextendedproperty
'MS_Description', N'排序',
'SCHEMA', N'dbo',
'TABLE', N'Sys_Menu',
'COLUMN', N'Sort'
GO

EXEC sp_addextendedproperty
'MS_Description', N'图标',
'SCHEMA', N'dbo',
'TABLE', N'Sys_Menu',
'COLUMN', N'Icon'
GO


-- ----------------------------
-- Records of Sys_Menu
-- ----------------------------
INSERT INTO [dbo].[Sys_Menu] ([Id], [MenuText], [CreateTime], [Sort], [Icon]) VALUES (N'0A306408-465B-4E67-AC61-869800EEAD7B', N'告警管理', N'2024-04-29 11:27:21.000', N'30', N'61527')
GO

INSERT INTO [dbo].[Sys_Menu] ([Id], [MenuText], [CreateTime], [Sort], [Icon]) VALUES (N'0AC49DB7-B6B2-45E2-8293-14B4E59BF507', N'库存', N'2024-04-29 11:22:20.000', N'17', N'261869')
GO

INSERT INTO [dbo].[Sys_Menu] ([Id], [MenuText], [CreateTime], [Sort], [Icon]) VALUES (N'0D1251ED-FD67-4D92-B3BC-C7942D035187', N'入库', N'2024-04-29 11:22:41.000', N'18', N'559913')
GO

INSERT INTO [dbo].[Sys_Menu] ([Id], [MenuText], [CreateTime], [Sort], [Icon]) VALUES (N'134A5582-1BD6-4F3D-A1F1-EB1813B333AA', N'用户管理', N'2024-04-03 15:08:21.237', N'1', N'358683')
GO

INSERT INTO [dbo].[Sys_Menu] ([Id], [MenuText], [CreateTime], [Sort], [Icon]) VALUES (N'1421BFE1-DF29-432B-AF36-FCB3802D4254', N'供应商', N'2024-04-29 11:21:37.000', N'15', N'563712')
GO

INSERT INTO [dbo].[Sys_Menu] ([Id], [MenuText], [CreateTime], [Sort], [Icon]) VALUES (N'27267EF8-9A13-49A2-A135-D00E4C53A942', N'箱规设置', N'2024-04-29 11:20:30.000', N'13', N'559913')
GO

INSERT INTO [dbo].[Sys_Menu] ([Id], [MenuText], [CreateTime], [Sort], [Icon]) VALUES (N'33B2C01E-A9FA-4CDB-8D46-4962CA3F7044', N'采购管理', N'2024-04-29 11:26:42.000', N'28', N'157431')
GO

INSERT INTO [dbo].[Sys_Menu] ([Id], [MenuText], [CreateTime], [Sort], [Icon]) VALUES (N'3952D18D-6A68-4ED5-B436-3D0F0593C2B2', N'刀具设置', N'2024-04-29 11:18:48.000', N'8', N'61459')
GO

INSERT INTO [dbo].[Sys_Menu] ([Id], [MenuText], [CreateTime], [Sort], [Icon]) VALUES (N'3FA04D7E-7452-4843-9598-F4763E267AAD', N'财务', N'2024-04-30 10:05:31.000', N'10005', N'558686')
GO

INSERT INTO [dbo].[Sys_Menu] ([Id], [MenuText], [CreateTime], [Sort], [Icon]) VALUES (N'44F3DB07-8745-4E85-80FA-2B3BD410F37C', N'供应商/客户', N'2024-04-30 10:04:21.000', N'10002', N'61950')
GO

INSERT INTO [dbo].[Sys_Menu] ([Id], [MenuText], [CreateTime], [Sort], [Icon]) VALUES (N'4AA26785-07B1-4F91-8EA5-6590A3294282', N'主料设置', N'2024-04-29 11:19:04.000', N'9', N'161886')
GO

INSERT INTO [dbo].[Sys_Menu] ([Id], [MenuText], [CreateTime], [Sort], [Icon]) VALUES (N'4F845AAC-8683-4B9B-8EE8-C03C072722AD', N'订单', N'2024-04-30 10:05:09.000', N'10004', N'362614')
GO

INSERT INTO [dbo].[Sys_Menu] ([Id], [MenuText], [CreateTime], [Sort], [Icon]) VALUES (N'4FD56966-A59D-42E9-85A2-CDABDD30CE8D', N'基础设置', N'2024-04-30 10:03:52.000', N'10001', N'61818')
GO

INSERT INTO [dbo].[Sys_Menu] ([Id], [MenuText], [CreateTime], [Sort], [Icon]) VALUES (N'551B3242-163E-4D4E-BE9B-F2176BF10E1D', N'告警设置', N'2024-04-29 11:16:27.000', N'5', N'358579')
GO

INSERT INTO [dbo].[Sys_Menu] ([Id], [MenuText], [CreateTime], [Sort], [Icon]) VALUES (N'556F75D0-6C7C-4D37-B915-06D6A4047C29', N'出库', N'2024-04-29 11:23:02.000', N'19', N'362798')
GO

INSERT INTO [dbo].[Sys_Menu] ([Id], [MenuText], [CreateTime], [Sort], [Icon]) VALUES (N'575D3BB8-347B-4734-AD64-EF9EDB3FBD20', N'订单补录', N'2024-04-29 11:24:31.000', N'22', N'358603')
GO

INSERT INTO [dbo].[Sys_Menu] ([Id], [MenuText], [CreateTime], [Sort], [Icon]) VALUES (N'5BFBFCFF-EF17-4621-A527-6174AEB5D996', N'固定资产', N'2024-04-29 11:27:00.000', N'29', N'557721')
GO

INSERT INTO [dbo].[Sys_Menu] ([Id], [MenuText], [CreateTime], [Sort], [Icon]) VALUES (N'62414182-EDEF-49B8-B257-22C2D49511EE', N'订单拆分', N'2024-04-29 11:24:12.000', N'21', N'357435')
GO

INSERT INTO [dbo].[Sys_Menu] ([Id], [MenuText], [CreateTime], [Sort], [Icon]) VALUES (N'6D840889-C4F5-4051-AA95-3655D9246EF7', N'角色管理', N'2024-04-03 15:08:34.380', N'4', N'261447')
GO

INSERT INTO [dbo].[Sys_Menu] ([Id], [MenuText], [CreateTime], [Sort], [Icon]) VALUES (N'87A8FB0D-09F3-4896-A37C-67955E59FA2E', N'库存管理', N'2024-04-30 10:04:48.000', N'10003', N'363055')
GO

INSERT INTO [dbo].[Sys_Menu] ([Id], [MenuText], [CreateTime], [Sort], [Icon]) VALUES (N'919E49FD-A1F4-414C-B3B3-CCE06538B0AD', N'工作记录', N'2024-04-29 11:25:20.000', N'24', N'362911')
GO

INSERT INTO [dbo].[Sys_Menu] ([Id], [MenuText], [CreateTime], [Sort], [Icon]) VALUES (N'967C3A02-512A-4D18-9B76-9FEF111CFB03', N'系统设置', N'2024-04-30 10:02:33.000', N'10000', N'61451')
GO

INSERT INTO [dbo].[Sys_Menu] ([Id], [MenuText], [CreateTime], [Sort], [Icon]) VALUES (N'A212C7A1-2339-4776-BE58-FF893387931B', N'菜单管理', N'2024-04-03 15:09:41.583', N'3', N'57460')
GO

INSERT INTO [dbo].[Sys_Menu] ([Id], [MenuText], [CreateTime], [Sort], [Icon]) VALUES (N'A3064C62-33FD-4B53-8A58-2D88F9040E75', N'规格设置', N'2024-04-29 11:20:52.000', N'14', N'163551')
GO

INSERT INTO [dbo].[Sys_Menu] ([Id], [MenuText], [CreateTime], [Sort], [Icon]) VALUES (N'AAAF30AA-3B76-4017-AE2A-C84DBE9E6559', N'公司管理', N'2024-04-03 15:08:57.727', N'2', N'358586')
GO

INSERT INTO [dbo].[Sys_Menu] ([Id], [MenuText], [CreateTime], [Sort], [Icon]) VALUES (N'AC4F2927-84EF-4B74-B0AE-E933AE3AE059', N'产品设置', N'2024-04-29 11:20:12.000', N'12', N'105')
GO

INSERT INTO [dbo].[Sys_Menu] ([Id], [MenuText], [CreateTime], [Sort], [Icon]) VALUES (N'ACDE61A2-AC34-46D4-B0A1-8F4E72D3E1D1', N'烫头设置', N'2024-04-29 11:18:17.000', N'7', N'357408')
GO

INSERT INTO [dbo].[Sys_Menu] ([Id], [MenuText], [CreateTime], [Sort], [Icon]) VALUES (N'B1376658-50AA-4973-9194-8E681B720853', N'幅宽设置', N'2024-04-29 11:17:53.000', N'6', N'358554')
GO

INSERT INTO [dbo].[Sys_Menu] ([Id], [MenuText], [CreateTime], [Sort], [Icon]) VALUES (N'B7FE3AAA-3153-46BE-BFF0-A65A526BDCD6', N'财务报表', N'2024-04-29 11:26:09.000', N'26', N'561996')
GO

INSERT INTO [dbo].[Sys_Menu] ([Id], [MenuText], [CreateTime], [Sort], [Icon]) VALUES (N'BF1DA0BF-7D7A-4A36-9DCF-781B74692ADB', N'考勤管理', N'2024-04-29 11:26:24.000', N'27', N'560392')
GO

INSERT INTO [dbo].[Sys_Menu] ([Id], [MenuText], [CreateTime], [Sort], [Icon]) VALUES (N'D3E9A7C1-E7B3-4BE9-ADCB-65E4E2CE9431', N'辅料设置', N'2024-04-29 11:19:30.000', N'10', N'358588')
GO

INSERT INTO [dbo].[Sys_Menu] ([Id], [MenuText], [CreateTime], [Sort], [Icon]) VALUES (N'D9BBC808-A4D2-44E3-889A-3366C74BF0DB', N'工人管理', N'2024-04-29 11:25:03.000', N'23', N'358142')
GO

INSERT INTO [dbo].[Sys_Menu] ([Id], [MenuText], [CreateTime], [Sort], [Icon]) VALUES (N'DC57CCC5-3EE5-4BE1-96F2-1CD011000E6E', N'工艺设置', N'2024-04-29 11:19:49.000', N'11', N'561707')
GO

INSERT INTO [dbo].[Sys_Menu] ([Id], [MenuText], [CreateTime], [Sort], [Icon]) VALUES (N'EC12768F-D31D-47B7-9D66-7ABA5676760A', N'客户', N'2024-04-29 11:21:53.000', N'16', N'357709')
GO

INSERT INTO [dbo].[Sys_Menu] ([Id], [MenuText], [CreateTime], [Sort], [Icon]) VALUES (N'F0611B95-BFFA-40E1-B5E4-2ED2159BF91B', N'订单管理', N'2024-04-29 11:23:20.000', N'20', N'61674')
GO

INSERT INTO [dbo].[Sys_Menu] ([Id], [MenuText], [CreateTime], [Sort], [Icon]) VALUES (N'F4920FF2-F90A-4B5F-9AC4-071A91BD2B40', N'财务日账', N'2024-04-29 11:25:42.000', N'25', N'61508')
GO


-- ----------------------------
-- Table structure for Sys_Menu_copy1
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Sys_Menu_copy1]') AND type IN ('U'))
	DROP TABLE [dbo].[Sys_Menu_copy1]
GO

CREATE TABLE [dbo].[Sys_Menu_copy1] (
  [Id] varchar(255) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [MenuText] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [CreateTime] datetime  NULL,
  [Sort] int  NULL,
  [Icon] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL
)
GO

ALTER TABLE [dbo].[Sys_Menu_copy1] SET (LOCK_ESCALATION = TABLE)
GO

EXEC sp_addextendedproperty
'MS_Description', N'主键Id',
'SCHEMA', N'dbo',
'TABLE', N'Sys_Menu_copy1',
'COLUMN', N'Id'
GO

EXEC sp_addextendedproperty
'MS_Description', N'菜单名称',
'SCHEMA', N'dbo',
'TABLE', N'Sys_Menu_copy1',
'COLUMN', N'MenuText'
GO

EXEC sp_addextendedproperty
'MS_Description', N'创建时间',
'SCHEMA', N'dbo',
'TABLE', N'Sys_Menu_copy1',
'COLUMN', N'CreateTime'
GO

EXEC sp_addextendedproperty
'MS_Description', N'排序',
'SCHEMA', N'dbo',
'TABLE', N'Sys_Menu_copy1',
'COLUMN', N'Sort'
GO

EXEC sp_addextendedproperty
'MS_Description', N'图标',
'SCHEMA', N'dbo',
'TABLE', N'Sys_Menu_copy1',
'COLUMN', N'Icon'
GO


-- ----------------------------
-- Records of Sys_Menu_copy1
-- ----------------------------
INSERT INTO [dbo].[Sys_Menu_copy1] ([Id], [MenuText], [CreateTime], [Sort], [Icon]) VALUES (N'0A306408-465B-4E67-AC61-869800EEAD7B', N'告警管理', N'2024-04-29 11:27:21.000', N'30', N'61527')
GO

INSERT INTO [dbo].[Sys_Menu_copy1] ([Id], [MenuText], [CreateTime], [Sort], [Icon]) VALUES (N'0AC49DB7-B6B2-45E2-8293-14B4E59BF507', N'库存', N'2024-04-29 11:22:20.000', N'17', N'0')
GO

INSERT INTO [dbo].[Sys_Menu_copy1] ([Id], [MenuText], [CreateTime], [Sort], [Icon]) VALUES (N'0D1251ED-FD67-4D92-B3BC-C7942D035187', N'入库', N'2024-04-29 11:22:41.000', N'18', N'559913')
GO

INSERT INTO [dbo].[Sys_Menu_copy1] ([Id], [MenuText], [CreateTime], [Sort], [Icon]) VALUES (N'134A5582-1BD6-4F3D-A1F1-EB1813B333AA', N'用户管理', N'2024-04-03 15:08:21.237', N'1', N'0')
GO

INSERT INTO [dbo].[Sys_Menu_copy1] ([Id], [MenuText], [CreateTime], [Sort], [Icon]) VALUES (N'1421BFE1-DF29-432B-AF36-FCB3802D4254', N'供应商', N'2024-04-29 11:21:37.000', N'15', N'0')
GO

INSERT INTO [dbo].[Sys_Menu_copy1] ([Id], [MenuText], [CreateTime], [Sort], [Icon]) VALUES (N'27267EF8-9A13-49A2-A135-D00E4C53A942', N'箱规设置', N'2024-04-29 11:20:30.000', N'13', N'0')
GO

INSERT INTO [dbo].[Sys_Menu_copy1] ([Id], [MenuText], [CreateTime], [Sort], [Icon]) VALUES (N'33B2C01E-A9FA-4CDB-8D46-4962CA3F7044', N'采购管理', N'2024-04-29 11:26:42.000', N'28', N'0')
GO

INSERT INTO [dbo].[Sys_Menu_copy1] ([Id], [MenuText], [CreateTime], [Sort], [Icon]) VALUES (N'3952D18D-6A68-4ED5-B436-3D0F0593C2B2', N'刀具设置', N'2024-04-29 11:18:48.000', N'8', N'61459')
GO

INSERT INTO [dbo].[Sys_Menu_copy1] ([Id], [MenuText], [CreateTime], [Sort], [Icon]) VALUES (N'4AA26785-07B1-4F91-8EA5-6590A3294282', N'主料设置', N'2024-04-29 11:19:04.000', N'9', N'0')
GO

INSERT INTO [dbo].[Sys_Menu_copy1] ([Id], [MenuText], [CreateTime], [Sort], [Icon]) VALUES (N'551B3242-163E-4D4E-BE9B-F2176BF10E1D', N'告警设置', N'2024-04-29 11:16:27.000', N'5', N'0')
GO

INSERT INTO [dbo].[Sys_Menu_copy1] ([Id], [MenuText], [CreateTime], [Sort], [Icon]) VALUES (N'556F75D0-6C7C-4D37-B915-06D6A4047C29', N'出库', N'2024-04-29 11:23:02.000', N'19', N'0')
GO

INSERT INTO [dbo].[Sys_Menu_copy1] ([Id], [MenuText], [CreateTime], [Sort], [Icon]) VALUES (N'575D3BB8-347B-4734-AD64-EF9EDB3FBD20', N'订单补录', N'2024-04-29 11:24:31.000', N'22', N'0')
GO

INSERT INTO [dbo].[Sys_Menu_copy1] ([Id], [MenuText], [CreateTime], [Sort], [Icon]) VALUES (N'5BFBFCFF-EF17-4621-A527-6174AEB5D996', N'固定资产', N'2024-04-29 11:27:00.000', N'29', N'0')
GO

INSERT INTO [dbo].[Sys_Menu_copy1] ([Id], [MenuText], [CreateTime], [Sort], [Icon]) VALUES (N'62414182-EDEF-49B8-B257-22C2D49511EE', N'订单拆分', N'2024-04-29 11:24:12.000', N'21', N'0')
GO

INSERT INTO [dbo].[Sys_Menu_copy1] ([Id], [MenuText], [CreateTime], [Sort], [Icon]) VALUES (N'6D840889-C4F5-4051-AA95-3655D9246EF7', N'角色管理', N'2024-04-03 15:08:34.380', N'4', N'261447')
GO

INSERT INTO [dbo].[Sys_Menu_copy1] ([Id], [MenuText], [CreateTime], [Sort], [Icon]) VALUES (N'919E49FD-A1F4-414C-B3B3-CCE06538B0AD', N'工作记录', N'2024-04-29 11:25:20.000', N'24', N'0')
GO

INSERT INTO [dbo].[Sys_Menu_copy1] ([Id], [MenuText], [CreateTime], [Sort], [Icon]) VALUES (N'A212C7A1-2339-4776-BE58-FF893387931B', N'菜单管理', N'2024-04-03 15:09:41.583', N'3', N'57460')
GO

INSERT INTO [dbo].[Sys_Menu_copy1] ([Id], [MenuText], [CreateTime], [Sort], [Icon]) VALUES (N'A3064C62-33FD-4B53-8A58-2D88F9040E75', N'规格设置', N'2024-04-29 11:20:52.000', N'14', N'0')
GO

INSERT INTO [dbo].[Sys_Menu_copy1] ([Id], [MenuText], [CreateTime], [Sort], [Icon]) VALUES (N'AAAF30AA-3B76-4017-AE2A-C84DBE9E6559', N'公司管理', N'2024-04-03 15:08:57.727', N'2', N'358586')
GO

INSERT INTO [dbo].[Sys_Menu_copy1] ([Id], [MenuText], [CreateTime], [Sort], [Icon]) VALUES (N'AC4F2927-84EF-4B74-B0AE-E933AE3AE059', N'产品设置', N'2024-04-29 11:20:12.000', N'12', N'0')
GO

INSERT INTO [dbo].[Sys_Menu_copy1] ([Id], [MenuText], [CreateTime], [Sort], [Icon]) VALUES (N'ACDE61A2-AC34-46D4-B0A1-8F4E72D3E1D1', N'烫头设置', N'2024-04-29 11:18:17.000', N'7', N'0')
GO

INSERT INTO [dbo].[Sys_Menu_copy1] ([Id], [MenuText], [CreateTime], [Sort], [Icon]) VALUES (N'B1376658-50AA-4973-9194-8E681B720853', N'幅宽设置', N'2024-04-29 11:17:53.000', N'6', N'0')
GO

INSERT INTO [dbo].[Sys_Menu_copy1] ([Id], [MenuText], [CreateTime], [Sort], [Icon]) VALUES (N'B7FE3AAA-3153-46BE-BFF0-A65A526BDCD6', N'财务报表', N'2024-04-29 11:26:09.000', N'26', N'0')
GO

INSERT INTO [dbo].[Sys_Menu_copy1] ([Id], [MenuText], [CreateTime], [Sort], [Icon]) VALUES (N'BF1DA0BF-7D7A-4A36-9DCF-781B74692ADB', N'考勤管理', N'2024-04-29 11:26:24.000', N'27', N'0')
GO

INSERT INTO [dbo].[Sys_Menu_copy1] ([Id], [MenuText], [CreateTime], [Sort], [Icon]) VALUES (N'D3E9A7C1-E7B3-4BE9-ADCB-65E4E2CE9431', N'辅料设置', N'2024-04-29 11:19:30.000', N'10', N'0')
GO

INSERT INTO [dbo].[Sys_Menu_copy1] ([Id], [MenuText], [CreateTime], [Sort], [Icon]) VALUES (N'D9BBC808-A4D2-44E3-889A-3366C74BF0DB', N'工人管理', N'2024-04-29 11:25:03.000', N'23', N'0')
GO

INSERT INTO [dbo].[Sys_Menu_copy1] ([Id], [MenuText], [CreateTime], [Sort], [Icon]) VALUES (N'DC57CCC5-3EE5-4BE1-96F2-1CD011000E6E', N'工艺设置', N'2024-04-29 11:19:49.000', N'11', N'0')
GO

INSERT INTO [dbo].[Sys_Menu_copy1] ([Id], [MenuText], [CreateTime], [Sort], [Icon]) VALUES (N'EC12768F-D31D-47B7-9D66-7ABA5676760A', N'客户', N'2024-04-29 11:21:53.000', N'16', N'0')
GO

INSERT INTO [dbo].[Sys_Menu_copy1] ([Id], [MenuText], [CreateTime], [Sort], [Icon]) VALUES (N'F0611B95-BFFA-40E1-B5E4-2ED2159BF91B', N'订单管理', N'2024-04-29 11:23:20.000', N'20', N'0')
GO

INSERT INTO [dbo].[Sys_Menu_copy1] ([Id], [MenuText], [CreateTime], [Sort], [Icon]) VALUES (N'F4920FF2-F90A-4B5F-9AC4-071A91BD2B40', N'财务日账', N'2024-04-29 11:25:42.000', N'25', N'0')
GO


-- ----------------------------
-- Table structure for Sys_Role
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Sys_Role]') AND type IN ('U'))
	DROP TABLE [dbo].[Sys_Role]
GO

CREATE TABLE [dbo].[Sys_Role] (
  [RoleId] int  IDENTITY(1,1) NOT NULL,
  [RoleName] varchar(255) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [CreateTime] datetime  NOT NULL,
  [MenuName] varchar(5000) COLLATE Chinese_PRC_CI_AS  NULL,
  [Sort] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL
)
GO

ALTER TABLE [dbo].[Sys_Role] SET (LOCK_ESCALATION = TABLE)
GO

EXEC sp_addextendedproperty
'MS_Description', N'主键自增长',
'SCHEMA', N'dbo',
'TABLE', N'Sys_Role',
'COLUMN', N'RoleId'
GO

EXEC sp_addextendedproperty
'MS_Description', N'当前职位人可以使用的菜单',
'SCHEMA', N'dbo',
'TABLE', N'Sys_Role',
'COLUMN', N'MenuName'
GO

EXEC sp_addextendedproperty
'MS_Description', N'当前职位人使用的菜单Id',
'SCHEMA', N'dbo',
'TABLE', N'Sys_Role',
'COLUMN', N'Sort'
GO


-- ----------------------------
-- Records of Sys_Role
-- ----------------------------
SET IDENTITY_INSERT [dbo].[Sys_Role] ON
GO

INSERT INTO [dbo].[Sys_Role] ([RoleId], [RoleName], [CreateTime], [MenuName], [Sort]) VALUES (N'10', N'经理', N'2024-04-03 16:13:28.443', N'用户管理;公司管理;菜单管理;角色管理;工作记录;', N'1;2;3;4;24;')
GO

INSERT INTO [dbo].[Sys_Role] ([RoleId], [RoleName], [CreateTime], [MenuName], [Sort]) VALUES (N'11', N'学生', N'2024-04-03 16:17:32.277', N'规格设置;供应商;告警管理;', N'14;15;30;')
GO

INSERT INTO [dbo].[Sys_Role] ([RoleId], [RoleName], [CreateTime], [MenuName], [Sort]) VALUES (N'12', N'部长', N'2024-04-07 11:18:40.427', N'用户管理;公司管理;角色管理;', N'1;2;4;')
GO

INSERT INTO [dbo].[Sys_Role] ([RoleId], [RoleName], [CreateTime], [MenuName], [Sort]) VALUES (N'13', N'老板', N'2024-04-29 14:29:53.517', N'用户管理;公司管理;菜单管理;角色管理;告警设置;幅宽设置;烫头设置;刀具设置;主料设置;辅料设置;工艺设置;产品设置;箱规设置;规格设置;供应商;客户;库存;入库;出库;订单管理;订单拆分;订单补录;工人管理;工作记录;财务日账;财务报表;考勤管理;采购管理;固定资产;告警管理;系统设置;基础设置;供应商/客户;库存管理;订单;财务;', N'1;2;3;4;5;6;7;8;9;10;11;12;13;14;15;16;17;18;19;20;21;22;23;24;25;26;27;28;29;30;10000;10001;10002;10003;10004;10005;')
GO

SET IDENTITY_INSERT [dbo].[Sys_Role] OFF
GO


-- ----------------------------
-- Table structure for Sys_User
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Sys_User]') AND type IN ('U'))
	DROP TABLE [dbo].[Sys_User]
GO

CREATE TABLE [dbo].[Sys_User] (
  [UserId] int  IDENTITY(1,1) NOT NULL,
  [Name] varchar(255) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [Password] varchar(255) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [Phone] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [Address] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [Sex] int  NOT NULL,
  [CreateTime] datetime  NOT NULL,
  [Account] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [Position] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [IsDelete] int  NULL
)
GO

ALTER TABLE [dbo].[Sys_User] SET (LOCK_ESCALATION = TABLE)
GO

EXEC sp_addextendedproperty
'MS_Description', N'主键Id',
'SCHEMA', N'dbo',
'TABLE', N'Sys_User',
'COLUMN', N'UserId'
GO

EXEC sp_addextendedproperty
'MS_Description', N'姓名',
'SCHEMA', N'dbo',
'TABLE', N'Sys_User',
'COLUMN', N'Name'
GO

EXEC sp_addextendedproperty
'MS_Description', N'密码',
'SCHEMA', N'dbo',
'TABLE', N'Sys_User',
'COLUMN', N'Password'
GO

EXEC sp_addextendedproperty
'MS_Description', N'电话',
'SCHEMA', N'dbo',
'TABLE', N'Sys_User',
'COLUMN', N'Phone'
GO

EXEC sp_addextendedproperty
'MS_Description', N'地址',
'SCHEMA', N'dbo',
'TABLE', N'Sys_User',
'COLUMN', N'Address'
GO

EXEC sp_addextendedproperty
'MS_Description', N'0男1女',
'SCHEMA', N'dbo',
'TABLE', N'Sys_User',
'COLUMN', N'Sex'
GO

EXEC sp_addextendedproperty
'MS_Description', N'创建时间',
'SCHEMA', N'dbo',
'TABLE', N'Sys_User',
'COLUMN', N'CreateTime'
GO

EXEC sp_addextendedproperty
'MS_Description', N'账号',
'SCHEMA', N'dbo',
'TABLE', N'Sys_User',
'COLUMN', N'Account'
GO

EXEC sp_addextendedproperty
'MS_Description', N'角色',
'SCHEMA', N'dbo',
'TABLE', N'Sys_User',
'COLUMN', N'Position'
GO

EXEC sp_addextendedproperty
'MS_Description', N'是否删除(0否,99是)',
'SCHEMA', N'dbo',
'TABLE', N'Sys_User',
'COLUMN', N'IsDelete'
GO


-- ----------------------------
-- Records of Sys_User
-- ----------------------------
SET IDENTITY_INSERT [dbo].[Sys_User] ON
GO

INSERT INTO [dbo].[Sys_User] ([UserId], [Name], [Password], [Phone], [Address], [Sex], [CreateTime], [Account], [Position], [IsDelete]) VALUES (N'26', N'大力', N'123456', N'1111', N'测试地址', N'1', N'2024-04-28 16:21:17.927', N'admin', N'老板', N'0')
GO

INSERT INTO [dbo].[Sys_User] ([UserId], [Name], [Password], [Phone], [Address], [Sex], [CreateTime], [Account], [Position], [IsDelete]) VALUES (N'1031', N'大力', N'123456', N'1111', N'2333333', N'0', N'2024-05-15 10:30:57.233', N'admin1', N'部长', N'0')
GO

INSERT INTO [dbo].[Sys_User] ([UserId], [Name], [Password], [Phone], [Address], [Sex], [CreateTime], [Account], [Position], [IsDelete]) VALUES (N'1032', N'大力5555', N'123456', N'1111', N'2333333', N'0', N'2024-05-15 10:35:12.807', N'admin16', N'部长', N'0')
GO

SET IDENTITY_INSERT [dbo].[Sys_User] OFF
GO


-- ----------------------------
-- Table structure for ToolSetup
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[ToolSetup]') AND type IN ('U'))
	DROP TABLE [dbo].[ToolSetup]
GO

CREATE TABLE [dbo].[ToolSetup] (
  [Id] varchar(255) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [ToolName] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [WideRating] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [FaultTolerant] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [Breadth] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [Coefficient] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [PermName] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [CreateTime] datetime  NULL,
  [CreateName] varchar(255) COLLATE Chinese_PRC_CI_AS  NULL,
  [IsDelete] int  NULL
)
GO

ALTER TABLE [dbo].[ToolSetup] SET (LOCK_ESCALATION = TABLE)
GO

EXEC sp_addextendedproperty
'MS_Description', N'主键Id',
'SCHEMA', N'dbo',
'TABLE', N'ToolSetup',
'COLUMN', N'Id'
GO

EXEC sp_addextendedproperty
'MS_Description', N'刀具名称',
'SCHEMA', N'dbo',
'TABLE', N'ToolSetup',
'COLUMN', N'ToolName'
GO

EXEC sp_addextendedproperty
'MS_Description', N'宽幅定额',
'SCHEMA', N'dbo',
'TABLE', N'ToolSetup',
'COLUMN', N'WideRating'
GO

EXEC sp_addextendedproperty
'MS_Description', N'容错值',
'SCHEMA', N'dbo',
'TABLE', N'ToolSetup',
'COLUMN', N'FaultTolerant'
GO

EXEC sp_addextendedproperty
'MS_Description', N'幅宽',
'SCHEMA', N'dbo',
'TABLE', N'ToolSetup',
'COLUMN', N'Breadth'
GO

EXEC sp_addextendedproperty
'MS_Description', N'系数 ',
'SCHEMA', N'dbo',
'TABLE', N'ToolSetup',
'COLUMN', N'Coefficient'
GO

EXEC sp_addextendedproperty
'MS_Description', N'烫头名称',
'SCHEMA', N'dbo',
'TABLE', N'ToolSetup',
'COLUMN', N'PermName'
GO

EXEC sp_addextendedproperty
'MS_Description', N'创建时间',
'SCHEMA', N'dbo',
'TABLE', N'ToolSetup',
'COLUMN', N'CreateTime'
GO

EXEC sp_addextendedproperty
'MS_Description', N'创建人名称',
'SCHEMA', N'dbo',
'TABLE', N'ToolSetup',
'COLUMN', N'CreateName'
GO

EXEC sp_addextendedproperty
'MS_Description', N'是否删除(0否,99是)',
'SCHEMA', N'dbo',
'TABLE', N'ToolSetup',
'COLUMN', N'IsDelete'
GO


-- ----------------------------
-- Records of ToolSetup
-- ----------------------------
INSERT INTO [dbo].[ToolSetup] ([Id], [ToolName], [WideRating], [FaultTolerant], [Breadth], [Coefficient], [PermName], [CreateTime], [CreateName], [IsDelete]) VALUES (N'0da19652-81d0-4a32-b451-e2e3196d39a6', N'大', N'大', N'0.1', N'幅宽1; 幅宽2; 幅宽3; 幅宽4; ', N'系数1; 系数2; 系数3; 系数4; ', N'烫头1; 烫头2; 烫头4; ', N'2024-05-07 09:51:23.560', N'大力1', N'99')
GO

INSERT INTO [dbo].[ToolSetup] ([Id], [ToolName], [WideRating], [FaultTolerant], [Breadth], [Coefficient], [PermName], [CreateTime], [CreateName], [IsDelete]) VALUES (N'3e3ca456-09af-4027-bef7-6bf8bad07ada', N'大2321312', N'大22222', N'0.13333', N'幅宽1; 幅宽4; ', N'系数1; 系数4; ', N'烫头1; 烫头4; ', N'2024-05-07 09:18:47.190', N'大力1', N'0')
GO

INSERT INTO [dbo].[ToolSetup] ([Id], [ToolName], [WideRating], [FaultTolerant], [Breadth], [Coefficient], [PermName], [CreateTime], [CreateName], [IsDelete]) VALUES (N'5cc93683-40c8-4101-b316-09f8fe1202fd', N'大2321312', N'大22222', N'0.13333', N'幅宽1; 幅宽4; ', N'系数1; 系数4; ', N'烫头1; 烫头4; ', N'2024-05-07 09:42:40.997', N'大力1', N'0')
GO

INSERT INTO [dbo].[ToolSetup] ([Id], [ToolName], [WideRating], [FaultTolerant], [Breadth], [Coefficient], [PermName], [CreateTime], [CreateName], [IsDelete]) VALUES (N'6e3d1a7e-b146-4185-a691-d630ddc01d69', N'刀具名称', N'10', N'0.1%', N'幅宽1; 幅宽2; 幅宽3; ', N'系数2; 系数3; ', N'烫头1; ', N'2024-05-07 09:18:15.820', N'大力', N'99')
GO

INSERT INTO [dbo].[ToolSetup] ([Id], [ToolName], [WideRating], [FaultTolerant], [Breadth], [Coefficient], [PermName], [CreateTime], [CreateName], [IsDelete]) VALUES (N'c966c4b4-30fd-4510-b95d-9ae14d6f5447', N'大', N'大', N'0.1', N'幅宽1; 幅宽2; 幅宽3; 幅宽4; ', N'系数1; 系数2; 系数3; 系数4; ', N'烫头1; 烫头2; 烫头4; ', N'2024-05-07 09:25:12.747', N'大力1', N'99')
GO

INSERT INTO [dbo].[ToolSetup] ([Id], [ToolName], [WideRating], [FaultTolerant], [Breadth], [Coefficient], [PermName], [CreateTime], [CreateName], [IsDelete]) VALUES (N'f77d0330-d228-4cf3-bccf-5b6d6a8f1fc8', N'大', N'大', N'0.12222', N'幅宽1; 幅宽2; 幅宽3; 幅宽4; ', N'系数1; 系数2; 系数3; 系数4; ', N'烫头1; 烫头2; 烫头4; ', N'2024-05-07 09:51:30.287', N'大力1', N'0')
GO

INSERT INTO [dbo].[ToolSetup] ([Id], [ToolName], [WideRating], [FaultTolerant], [Breadth], [Coefficient], [PermName], [CreateTime], [CreateName], [IsDelete]) VALUES (N'sdf', N'刀具名称', N'10', N'0.1%', N'0.2%', N'10', N'烫头', N'2024-05-06 17:22:07.000', N'大力', N'0')
GO


-- ----------------------------
-- Primary Key structure for table Alarm_Setting
-- ----------------------------
ALTER TABLE [dbo].[Alarm_Setting] ADD CONSTRAINT [PK__Alarm_se__3214EC07CB38BB0E] PRIMARY KEY CLUSTERED ([Id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table AuditLog
-- ----------------------------
ALTER TABLE [dbo].[AuditLog] ADD CONSTRAINT [PK_AuditLog_Id] PRIMARY KEY CLUSTERED ([Id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table BePutInStorage
-- ----------------------------
ALTER TABLE [dbo].[BePutInStorage] ADD CONSTRAINT [PK__BePutInS__3214EC07BF978A84] PRIMARY KEY CLUSTERED ([Id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table BoxGaugeSetting
-- ----------------------------
ALTER TABLE [dbo].[BoxGaugeSetting] ADD CONSTRAINT [PK__BoxGauge__3214EC07D99F8C89] PRIMARY KEY CLUSTERED ([Id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table Breadth
-- ----------------------------
ALTER TABLE [dbo].[Breadth] ADD CONSTRAINT [PK__Breadth__3214EC07464E9D94] PRIMARY KEY CLUSTERED ([Id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table Cap_AlarmManagement
-- ----------------------------
ALTER TABLE [dbo].[Cap_AlarmManagement] ADD CONSTRAINT [PK__Cap_Alar__3214EC07408F67A3] PRIMARY KEY CLUSTERED ([Id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table Cap_AttendanceManagement
-- ----------------------------
ALTER TABLE [dbo].[Cap_AttendanceManagement] ADD CONSTRAINT [PK__Cap_Atte__3214EC075011B1B2] PRIMARY KEY CLUSTERED ([Id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table Cap_Company
-- ----------------------------
ALTER TABLE [dbo].[Cap_Company] ADD CONSTRAINT [PK__Company__3214EC070C450D8D] PRIMARY KEY CLUSTERED ([Id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table Cap_FinancialDailyAccount
-- ----------------------------
ALTER TABLE [dbo].[Cap_FinancialDailyAccount] ADD CONSTRAINT [PK__Cap_Fina__3214EC076A8C29AF] PRIMARY KEY CLUSTERED ([Id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table Cap_FinancialStatements
-- ----------------------------
ALTER TABLE [dbo].[Cap_FinancialStatements] ADD CONSTRAINT [PK__Cap_Fina__3214EC07EBD965D0] PRIMARY KEY CLUSTERED ([Id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table Cap_FixedAssets
-- ----------------------------
ALTER TABLE [dbo].[Cap_FixedAssets] ADD CONSTRAINT [PK__Cap_Fixe__3214EC070FB7DAEE] PRIMARY KEY CLUSTERED ([Id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table Cap_OrderManagement
-- ----------------------------
ALTER TABLE [dbo].[Cap_OrderManagement] ADD CONSTRAINT [PK__outbound__3214EC0761CC418B] PRIMARY KEY CLUSTERED ([Id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table Cap_OrderSplitting
-- ----------------------------
ALTER TABLE [dbo].[Cap_OrderSplitting] ADD CONSTRAINT [PK__Cap_Orde__3214EC07D9BCCFB3] PRIMARY KEY CLUSTERED ([Id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table Cap_PurchasingManagement
-- ----------------------------
ALTER TABLE [dbo].[Cap_PurchasingManagement] ADD CONSTRAINT [PK__Cap_Purc__3214EC078432BEB8] PRIMARY KEY CLUSTERED ([Id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table Cap_WorkerManagement
-- ----------------------------
ALTER TABLE [dbo].[Cap_WorkerManagement] ADD CONSTRAINT [PK__Cap_Work__3214EC07030A8884] PRIMARY KEY CLUSTERED ([Id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table Cap_WorkRecord
-- ----------------------------
ALTER TABLE [dbo].[Cap_WorkRecord] ADD CONSTRAINT [PK__Cap_Work__3214EC07439C5155] PRIMARY KEY CLUSTERED ([Id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table ChargeTime
-- ----------------------------
ALTER TABLE [dbo].[ChargeTime] ADD CONSTRAINT [PK__ChargeTi__3214EC07BCF9027B] PRIMARY KEY CLUSTERED ([Id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table Consumer
-- ----------------------------
ALTER TABLE [dbo].[Consumer] ADD CONSTRAINT [PK__Consumer__3214EC072D7E9A4E] PRIMARY KEY CLUSTERED ([Id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table MajorIngredient
-- ----------------------------
ALTER TABLE [dbo].[MajorIngredient] ADD CONSTRAINT [PK__MajorIng__3214EC075CA8BAB4] PRIMARY KEY CLUSTERED ([Id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table OrderSupplement
-- ----------------------------
ALTER TABLE [dbo].[OrderSupplement] ADD CONSTRAINT [PK__OrderSup__3214EC07139F568B] PRIMARY KEY CLUSTERED ([Id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table OutboundManager
-- ----------------------------
ALTER TABLE [dbo].[OutboundManager] ADD CONSTRAINT [PK__Outbound__3214EC0764A71A32] PRIMARY KEY CLUSTERED ([Id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table PermSetting
-- ----------------------------
ALTER TABLE [dbo].[PermSetting] ADD CONSTRAINT [PK__Perm__3214EC072D1B0DE2] PRIMARY KEY CLUSTERED ([Id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table ProcessSetting
-- ----------------------------
ALTER TABLE [dbo].[ProcessSetting] ADD CONSTRAINT [PK__ProcessS__3214EC073E23DD63] PRIMARY KEY CLUSTERED ([Id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table ProductSetup
-- ----------------------------
ALTER TABLE [dbo].[ProductSetup] ADD CONSTRAINT [PK__ProductS__3214EC077398EBC2] PRIMARY KEY CLUSTERED ([Id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table SpecificationSetting
-- ----------------------------
ALTER TABLE [dbo].[SpecificationSetting] ADD CONSTRAINT [PK__Specific__3214EC0780D7BDFB] PRIMARY KEY CLUSTERED ([Id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table Stocks
-- ----------------------------
ALTER TABLE [dbo].[Stocks] ADD CONSTRAINT [PK__Stocks__3214EC074B576F63] PRIMARY KEY CLUSTERED ([Id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table SupplierName
-- ----------------------------
ALTER TABLE [dbo].[SupplierName] ADD CONSTRAINT [PK__Supplier__3214EC07EBA8D343] PRIMARY KEY CLUSTERED ([Id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table Sys_Menu
-- ----------------------------
ALTER TABLE [dbo].[Sys_Menu] ADD CONSTRAINT [PK__Sys_Menu__3214EC07C3AA327C] PRIMARY KEY CLUSTERED ([Id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table Sys_Menu_copy1
-- ----------------------------
ALTER TABLE [dbo].[Sys_Menu_copy1] ADD CONSTRAINT [PK__Sys_Menu__3214EC07C67A7D13] PRIMARY KEY CLUSTERED ([Id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Auto increment value for Sys_Role
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[Sys_Role]', RESEED, 1012)
GO


-- ----------------------------
-- Primary Key structure for table Sys_Role
-- ----------------------------
ALTER TABLE [dbo].[Sys_Role] ADD CONSTRAINT [PK_Sys_Role_RoleId] PRIMARY KEY CLUSTERED ([RoleId])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Auto increment value for Sys_User
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[Sys_User]', RESEED, 1032)
GO


-- ----------------------------
-- Primary Key structure for table Sys_User
-- ----------------------------
ALTER TABLE [dbo].[Sys_User] ADD CONSTRAINT [PK_Sys_User_UserId] PRIMARY KEY CLUSTERED ([UserId])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table ToolSetup
-- ----------------------------
ALTER TABLE [dbo].[ToolSetup] ADD CONSTRAINT [PK__ToolSetu__3214EC076F4BA077] PRIMARY KEY CLUSTERED ([Id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO

