/*exec CheckIsUseByNumber 493*/
CREATE PROCEDURE [dbo].[CheckIsUseByNumber]
(
	@Number	INT
)
AS
BEGIN
     SELECT [IsUse] FROM dbo.DataMosRuType
	 WHERE [Number] = @Number
END
