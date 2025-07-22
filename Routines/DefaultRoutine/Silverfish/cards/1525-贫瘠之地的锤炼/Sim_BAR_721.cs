using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BAR_721 : SimTemplate //* 曼科里克 Mankrik
	{
        //[x]<b>Battlecry:</b> Help Mankrik findhis wife! She was last seensomewhere in your deck.
        //<b>战吼：</b>帮助曼科里克寻找他的妻子！她曾出现在你牌库中的某个地方。
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            p.setMankrik = true;
        }
    }
}
