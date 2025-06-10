namespace HREngine.Bots
{
	class Sim_GILA_BOSS_68p : SimTemplate //* 毒药瓶 Poison Flask
//<b>Hero Power</b>Deal $2 damage to a minion. If it survives, give it <b>Poisonous</b>.
//<b>英雄技能</b>对一个随从造成$2点伤害。如果该随从没有死亡，则获得<b>剧毒</b>。 
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