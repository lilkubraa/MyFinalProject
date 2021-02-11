using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{

    public class SuccessDataResult<T> : DataResult<T>
    {
        private List<global::DataAccess.Abstract.ProductDetailsDto> lists;
        private List<global::DataAccess.Abstract.ProductDetailsDto> lists1;

        public SuccessDataResult(T data, string message) : base(data, true, message)
        {

        }

        public SuccessDataResult(T data) : base(data, true)
        {

        }

        public SuccessDataResult(string message) : base(default, true, message)
        {

        }

        public SuccessDataResult(List<global::DataAccess.Abstract.ProductDetailsDto> lists) : base(default, true)
        {

        }

        public SuccessDataResult(List<global::DataAccess.Abstract.ProductDetailsDto> lists)
        {
            this.lists = lists;
        }

        public SuccessDataResult(List<global::DataAccess.Abstract.ProductDetailsDto> lists1)
        {
            this.lists1 = lists1;
        }
    }
}