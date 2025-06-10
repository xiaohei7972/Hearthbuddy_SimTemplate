using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_DED_007 : SimTemplate //* 迪菲亚炸鱼手 Defias Blastfisher
    {
        //战吼：随机对一个敌人造成2点伤害。每有一只你的野兽，重复一次
        //Battlecry: Deal 2 damage to a random enemy. Repeat for each of your Beasts..
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            if (target != null)
            {
                //p.minionGetBuffed(own, 2, 3);
                //p.minionGetRush(own);
            }
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE),
            };
        }
    }
}
