using System;


using System.Collections.Generic;


using System.Text;





namespace HREngine.Bots


{


	class Sim_BOM_07_Scabbs_Bob_001p : SimTemplate //* 凶恶命运 Foreboding Fate


	{


		//[x]<b>Hero Power</b>Trigger a friendlyminion's <b>Deathrattle</b>.


		//<b>英雄技能</b>触发一个友方随从的<b>亡语</b>。


		


		





        public override PlayReq[] GetPlayReqs()


        {


            return new PlayReq[] {


                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),


                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),


                new PlayReq(CardDB.ErrorType2.REQ_TARGET_WITH_DEATHRATTLE),


                new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET),


            };


        }


	}


}


