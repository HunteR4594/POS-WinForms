    -- Always back up your database before running DDL commands!

    -- Create the SaleItems table if it does not already exist
    IF OBJECT_ID(N'[dbo].[SaleItems]', 'U') IS NULL
    BEGIN
        CREATE TABLE [dbo].[SaleItems] (
            [Id] INT IDENTITY(1,1) NOT NULL,
            [SaleId] INT NOT NULL,           -- Foreign Key to the Sales table
            [ProdId] NVARCHAR(MAX) NOT NULL, -- Product ID string
            [ProdName] NVARCHAR(MAX) NOT NULL, -- Product Name string
            [Quantity] INT NOT NULL,         -- Quantity of the product
            [OrigPrice] DECIMAL(18,2) NOT NULL, -- Original Unit Price of the product (decimal(18,2) as configured in AppDbContext)
            [TotalPrice] DECIMAL(18,2) NOT NULL, -- Total Price for this item line (decimal(18,2) as configured in AppDbContext)
            CONSTRAINT [PK_SaleItems] PRIMARY KEY ([Id])
        );
        PRINT 'Table [dbo].[SaleItems] created successfully.';
    END
    ELSE
    BEGIN
        PRINT 'Table [dbo].[SaleItems] already exists.';
    END
    GO

    -- Add Foreign Key constraint to link SaleItems to Sales
    -- This assumes the 'Sales' table already exists.
    IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_SaleItems_Sales_SaleId]') AND parent_object_id = OBJECT_ID(N'[dbo].[SaleItems]'))
    BEGIN
        -- Check if Sales table exists before adding FK
        IF OBJECT_ID(N'[dbo].[Sales]', 'U') IS NOT NULL
        BEGIN
            ALTER TABLE [dbo].[SaleItems]
            ADD CONSTRAINT [FK_SaleItems_Sales_SaleId] FOREIGN KEY ([SaleId]) REFERENCES [dbo].[Sales] ([id]) ON DELETE CASCADE;
            PRINT 'Foreign Key FK_SaleItems_Sales_SaleId added successfully.';
        END
        ELSE
        BEGIN
            PRINT 'Cannot add Foreign Key: Table [dbo].[Sales] does not exist.';
        END
    END
    ELSE
    BEGIN
        PRINT 'Foreign Key FK_SaleItems_Sales_SaleId already exists.';
    END
    GO

    -- Also, ensure the __EFMigrationsHistory table knows this migration was applied.
    -- This step is for consistency with EF Core's tracking.
    IF NOT EXISTS (SELECT 1 FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20250619141648_AddSaleItemsAndConfigureRelationships')
    BEGIN
        INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
        VALUES (N'20250619141648_AddSaleItemsAndConfigureRelationships', N'9.0.5');
        PRINT 'Migration entry for 20250619141648_AddSaleItemsAndConfigureRelationships added to __EFMigrationsHistory.';
    END
    ELSE
    BEGIN
        PRINT 'Migration entry for 20250619141648_AddSaleItemsAndConfigureRelationships already exists in __EFMigrationsHistory.';
    END
    GO

    -- If you still have the empty migration entry, you might need to add that too for consistency:
    IF NOT EXISTS (SELECT 1 FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20250619143827_AddSaleItemsAndConfigureSales')
    BEGIN
        INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
        VALUES (N'20250619143827_AddSaleItemsAndConfigureSales', N'9.0.5');
        PRINT 'Migration entry for 20250619143827_AddSaleItemsAndConfigureSales added to __EFMigrationsHistory.';
    END
    ELSE
    BEGIN
        PRINT 'Migration entry for 20250619143827_AddSaleItemsAndConfigureSales already exists in __EFMigrationsHistory.';
    END
    GO
    