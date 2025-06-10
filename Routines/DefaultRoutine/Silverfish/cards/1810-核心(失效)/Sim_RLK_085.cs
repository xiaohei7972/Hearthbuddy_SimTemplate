
using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_RLK_085 : SimTemplate //* 玛洛加尔领主 Lord Marrowgar
                                    //&lt;b&gt;战吼：&lt;/b&gt;将你的所有&lt;b&gt;尸体&lt;/b&gt;复活为1/1并具有&lt;b&gt;突袭&lt;/b&gt;的复活的傀儡。每有一个放不下的傀儡，使一个傀儡获得+2/+2。
                                    //&lt;b&gt;Battlecry:&lt;/b&gt; Raise ALL of your&lt;b&gt;Corpses&lt;/b&gt; as 1/1 Risen Golemswith &lt;b&gt;Rush&lt;/b&gt;. For each that can'tfit, give one +2/+2.
    {

		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            p.corpseConsumption(p.getCorpseCount());	//直接把尸体消耗完，在策略里面写出牌时机比较好
        }
    }


}
        