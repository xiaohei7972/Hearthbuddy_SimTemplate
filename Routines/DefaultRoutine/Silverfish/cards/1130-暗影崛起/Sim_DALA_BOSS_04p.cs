namespace HREngine.Bots
{
	class Sim_DALA_BOSS_04p : SimTemplate //* 打开虫洞 Open Wormhole
//<b>Hero Power</b>Both players summon a minion from their deck. They fight.
//<b>英雄技能</b>从双方玩家的牌库中各召唤一个随从，并使其互相攻击。 
	{
		
		



        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINION_OR_ENEMY_HERO),
            };
        }
	}
}