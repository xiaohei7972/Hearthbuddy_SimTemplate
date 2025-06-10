namespace HREngine.Bots
{
	class Sim_ULDA_BOSS_18p : SimTemplate //* 染病团伙 Plagued Horde
//[x]<b>Hero Power</b>Give a minion"<b>Deathrattle:</b> Deal 2 damageto the enemy hero."
//<b>英雄技能</b>使一个随从获得“<b>亡语：</b>对敌方英雄造成2点伤害”。 
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