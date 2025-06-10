namespace HREngine.Bots
{
	class Sim_GILA_BOSS_22p : SimTemplate //* 剖击 Shank
//<b>Hero Power</b>Deal $1 damage to a minion. Draw a card.
//<b>英雄技能</b>对一个随从造成$1点伤害。抽一张牌。 
	{
		
		



        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
	}
}