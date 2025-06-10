namespace HREngine.Bots
{
	class Sim_ULDA_BOSS_10p : SimTemplate //* 装备精良 Well Equipped
//[x]<b>Hero Power</b>Put a random RogueSpell or Weaponinto your hand.
//<b>英雄技能</b>随机将一张潜行者法术牌或武器牌置入你的手牌。 
	{
		
		



        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
	}
}