namespace HREngine.Bots
{
	class Sim_DALA_BOSS_46p : SimTemplate //* 泡泡护盾 Protective Bubble
//[x]<b>Hero Power</b>Give a friendly minion<b>Divine Shield</b>.
//<b>英雄技能</b>使一个友方随从获得<b>圣盾</b>。 
	{
		
		



        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
	}
}