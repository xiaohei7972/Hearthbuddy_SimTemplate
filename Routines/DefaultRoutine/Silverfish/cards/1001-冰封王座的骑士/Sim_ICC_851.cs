using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_ICC_851: SimTemplate //* 凯雷塞斯王子 Prince Keleseth
//<b>Battlecry:</b> If your deck has_no 2-Cost cards, give_all minions in your deck +1/+1.
//<b>战吼：</b>如果你的牌库里没有法力值消耗为（2）的牌，则你的牌库里所有随从牌获得+1/+1。 
    {
        

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            if (own.own && p.prozis.getDeckCardsForCost(2) == CardDB.cardIDEnum.None) p.evaluatePenality -= 20;
        }
    }
}