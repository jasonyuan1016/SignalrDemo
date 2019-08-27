CREATE TABLE [dbo].[income](
	[id] [uniqueidentifier] NOT NULL,
	[amount] [money] NOT NULL,
	[ctime] [datetime] NOT NULL,
	[state] [tinyint] NOT NULL,
	[modifier] [varchar](20) NULL,
	[utime] [datetime] NULL,
	[etime] [datetime] NULL,
 CONSTRAINT [PK_income] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[income] ADD  CONSTRAINT [DF_income_id]  DEFAULT (newid()) FOR [id]
GO

ALTER TABLE [dbo].[income] ADD  CONSTRAINT [DF_income_ctime]  DEFAULT (getdate()) FOR [ctime]
GO

ALTER TABLE [dbo].[income] ADD  CONSTRAINT [DF_income_state]  DEFAULT ((0)) FOR [state]
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'����' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'income', @level2type=N'COLUMN',@level2name=N'id'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'���' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'income', @level2type=N'COLUMN',@level2name=N'amount'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'����ʱ��' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'income', @level2type=N'COLUMN',@level2name=N'ctime'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'0δ���� 1������ 2�ɹ� 3ʧ�� ����' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'income', @level2type=N'COLUMN',@level2name=N'state'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'������' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'income', @level2type=N'COLUMN',@level2name=N'modifier'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'����ʱ��' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'income', @level2type=N'COLUMN',@level2name=N'utime'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'���ʱ��' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'income', @level2type=N'COLUMN',@level2name=N'etime'
GO


