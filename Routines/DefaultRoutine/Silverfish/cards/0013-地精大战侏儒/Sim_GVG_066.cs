using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_GVG_066 : SimTemplate //* 砂槌萨满祭司 Dunemaul Shaman
//<b>Windfury, Overload:</b> (1)50% chance to attack the wrong enemy.
//<b>风怒，过载：</b>（1）50%几率攻击错误的敌人。 
    {
        

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            if (own.own) p.ueberladung++;
        }
    }
}