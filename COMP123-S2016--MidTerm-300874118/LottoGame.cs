﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
* Author: Inderjeet Singh
* Student Number: 300874118
* Date Created: June 24, 2016
* Description: My Hero Class
* Version: 0.0.1
*/
namespace COMP123_S2016__MidTerm_300874118
{
    /**
     * <summary>
     * This abstract class is a blueprint for all Lotto Games
     * </summary>
     * 
     * @class LottoGame
     * @property {int} ElementNum;
     * @property {int} SetSize;
     */
    public abstract class LottoGame
    {
        

        // CREATE private fields here --------------------------------------------
        private List<int> _elementList;
        private int _elementNumber;
        private List<int> _numberList;
        private Random _random;
        private int _setSize;

        // PUBLIC PROPERTIES ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        // CREATE public properties here -----------------------------------------

        /**
         * <summary>
         * this is property for our private _elementList field
         * </summary>
         * @property List<int> ElementList
         */
        public List<int> ElementList
        {
            get
            {
                return this._elementList;
            }

            set
            {
                this._elementList = value;
            }
        }
        /**
        * <summary>
        * this is property for our private _elementNumber field
        * </summary>
        * @property int ElementNumber
        */

        public int ElementNumber
        {
            get
            {
                return this._elementNumber;
            }

            set
            {
                this._elementNumber = value;
            }
        }

        /**
         * <summary>
         * this is property for our private _numberList field
         * </summary>
         * @property List<int> NumberList
         */
        public List<int> NumberList
        {
            get
            {
                return this._numberList;
            }

            set
            {
                this._numberList = value;
            }
        }
        /**
         * <summary>
         * this is property for our private _random field
         * </summary>
         * @property Random Random
         */
        public Random Random
        {
            get
            {
                return this._random;
            }

            set
            {
                this.Random = value;
            }
        }
        /**
         * <summary>
         * this is property for our private SetSize field
         * </summary>
         * @property int SetSize
         */
        public int SetSize
        {
            get
            {
                return this._setSize;
            }

            set
            {
                this._setSize = value;
            }
        }


        // CONSTRUCTORS +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        /**
         * <summary>
         * This constructor takes two parameters: elementNumber and setSize
         * The elementNumber parameter has a default value of 6
         * The setSize parameter has a default value of 49
         * </summary>
         * 
         * @constructor LottoGame
         * @param {int} elementNumber
         * @param {int} setSize
         */
        public LottoGame(int elementNumber = 6, int setSize = 49)
        {
            // assign elementNumber local variable to the ElementNumber property
            this.ElementNumber = elementNumber;

            // assign setSize local variable tot he SetSize property
            this.SetSize = setSize;

            // call the _initialize method
            this._initialize();

            // call the _build method
            this._build();
        }



        // PRIVATE METHODS ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        // CREATE the private _build method here -----------------------------------

        /**
        * <summary>
        * This method generates Integer Literals
        * </summary>
        * @method _build
        * @return {void}
        */
        private void _build()
        {
       

            for (int i = 1; i < SetSize; i++)
            {

                NumberList.Add(i);

            }
        }

        // CREATE the private _initialize method here -----------------------------

        private void _initialize()
        {


            throw new System.NotImplementedException();
        }

       


        // OVERRIDEN METHODS ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        /**
         * <summary>
         * Override the default ToString function so that it displays the current
         * ElementList
         * </summary>
         * 
         * @override
         * @method ToString
         * @returns {string}
         */
        public override string ToString()
        {
            // create a string variable named lottoNumberString and intialize it with the empty string
            string lottoNumberString = String.Empty;

            // for each lottoNumber in ElementList, loop...
            foreach (int lottoNumber in ElementList)
            {
                // add lottoNumber and appropriate spaces to the lottoNumberString variable
                lottoNumberString += lottoNumber > 9 ? (lottoNumber + " ") : (lottoNumber + "  ");
            }

            return lottoNumberString;
        }


    // CREATE the public PickElements method here ----------------------------

         public void PickElements()
        {
            if (ElementList.Count > 0)
            {
                ElementList.Clear();
                NumberList.Clear();

                _build();
                for(int i=0;i<ElementNumber;i++)
                { 
                int randomIntegr = this.Random.Next(0, NumberList.Count);
                ElementList.Add(NumberList[randomIntegr]);
                NumberList.RemoveAt(randomIntegr);
                }
            }
        }
        // PUBLIC METHODS +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        public void GenerateLottoNumbers();
        {


        }
    }
}
