using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_VAN_EX1_334 : SimTemplate //* 暗影狂乱 Shadow Madness
	{
		//Gain control of an enemy minion with 3 or less Attack until end of turn.
		//直到回合结束，获得一个攻击力小于或等于3的敌方随从的控制权。
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            target.shadowmadnessed = true;
            p.shadowmadnessed++;
            p.minionGetControlled(target, ownplay, true);
		}


        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_MAX_ATTACK, 3),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_NUM_MINION_SLOTS, 1),
            };
        }
	}
}