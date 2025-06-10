namespace HREngine.Bots
{
	class Sim_ULDA_Elise_HP2 : SimTemplate //* 德鲁伊教学 Druidic Teaching
//[x]<b>Hero Power</b>Restore #2 Health, thendraw a card if the targetis at full Health.
//<b>英雄技能</b>恢复#2点生命值。此时如果目标拥有所有生命值，抽一张牌。 
	{
		
		



        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
            };
        }
	}
}