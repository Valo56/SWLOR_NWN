
BEGIN TRANSACTION

UPDATE dbo.PlayerCharacters
SET PrimaryResidencePCBaseID = NULL,
	PrimaryResidencePCBaseStructureID = NULL 

DELETE FROM dbo.ChatLog

DELETE FROM dbo.PCBaseStructureItems

DELETE FROM dbo.PCBaseStructurePermissions

DELETE FROM dbo.PCBasePermissions

DELETE FROM dbo.PCBaseStructures

DELETE FROM dbo.PCBases

DELETE FROM dbo.AreaWalkmesh

DELETE FROM dbo.Areas

DELETE FROM dbo.PCCraftedBlueprints

DELETE FROM dbo.PCCooldowns

DELETE FROM dbo.PCCustomEffects

DELETE FROM dbo.PCKeyItems

DELETE FROM dbo.PCPerks

DELETE FROM dbo.PCSkills

DELETE FROM dbo.PCObjectVisibility

DELETE FROM dbo.PCMigrationItems

DELETE FROM dbo.PCMigrations

DELETE FROM dbo.PCOutfits

DELETE FROM dbo.PCOverflowItems

DELETE FROM dbo.PCSearchSiteItems

DELETE FROM dbo.PCSearchSites

DELETE FROM dbo.PCRegionalFame

DELETE FROM dbo.PCQuestItemProgress

DELETE FROM dbo.PCQuestKillTargetProgress

DELETE FROM dbo.PCQuestStatus

DELETE FROM dbo.BugReports

DELETE FROM dbo.ClientLogEvents

DELETE FROM dbo.PCMapPins

DELETE FROM dbo.PCImpoundedItems

DELETE FROM dbo.PCPerkRefunds

DELETE FROM dbo.BankItems

DELETE FROM dbo.Banks

DELETE FROM dbo.PCMapProgression

DELETE FROM dbo.PlayerCharacters

DELETE FROM dbo.GrowingPlants

-- rollback
-- commit

