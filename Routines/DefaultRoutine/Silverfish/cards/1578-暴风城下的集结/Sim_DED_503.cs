using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_DED_503 : SimTemplate //* 暗影之刃飞刀手 Shadowblade Slinger
    {
        //战吼：如果你在本回合中受到过伤害，则对一个敌方随从造成等量的伤害。
        //Battlecry: If you've taken damage this turn, deal that much to an enemy minion.
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {

        }
    }
}
