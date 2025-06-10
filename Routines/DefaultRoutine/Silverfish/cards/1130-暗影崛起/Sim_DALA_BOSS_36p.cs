namespace HREngine.Bots
{
	class Sim_DALA_BOSS_36p : SimTemplate //* 采购“宠物” Import "Pet"
//<b>Hero Power</b>Craft a custom Exotic Pet.
//<b>英雄技能</b>制造一个自定义的特殊宠物。 
	{
		
		



        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_HAND_NOT_FULL),
            };
        }
	}
}