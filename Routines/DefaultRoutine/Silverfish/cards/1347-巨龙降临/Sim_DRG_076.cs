namespace HREngine.Bots
{
	class Sim_DRG_076 : SimTemplate //* 无面腐蚀者 Faceless Corruptor
	{
		//[x]<b>Rush</b>. <b>Battlecry:</b> Transformone of your minions intoa copy of this.
		//<b>突袭，战吼：</b>将你的一个随从变形成为该随从的复制。
		public override void getBattlecryEffect(Playfield p, Minion m, Minion target, int choice) 
        { 
            if (target != null) 
            { 
               p.minionTransform(target, m.handcard.card); 
            } 
        }


        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE),
                new PlayReq(CardDB.ErrorType2.REQ_NONSELF_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET),
            };
        }
    }
}