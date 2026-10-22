BEGIN TRANSACTION;
GO

EXEC sp_rename N'[AppPromotionManufacturers].[ManufactureId]', N'ManufacturerId', N'COLUMN';
GO

EXEC sp_rename N'[AppProducts].[ManufactureId]', N'ManufacturerId', N'COLUMN';
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20261022152747_RenameManufactureIdToManufacturerId', N'6.0.5');
GO

COMMIT;
GO

