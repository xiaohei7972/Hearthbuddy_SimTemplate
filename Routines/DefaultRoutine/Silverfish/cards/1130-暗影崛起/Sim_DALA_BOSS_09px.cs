namespace HREngine.Bots
{
	class Sim_DALA_BOSS_09px : SimTemplate //* 历史重演 Repeat History
//<b>Hero Power</b>Summon a random friendly minion that died this game.
//<b>英雄技能</b>随机召唤一个在本局对战中死亡的友方随从。 
	{
		
		



        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_NUM_MINION_SLOTS, 1),
                new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_MINION_DIED_THIS_GAME),
            };
        }
	}
}