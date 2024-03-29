﻿using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Application.Exceptions
{
    public class ApiException : Exception
    {
        public ApiException() : base() { }

        public ApiException(string message) : base(message) { }

        public ApiException(string message, params object[] args)
            : base(String.Format(CultureInfo.CurrentCulture, message, args))
        {
        }
    }
    public class CreateRequestException : ApiException
    {
        public CreateRequestException(string message) : base(message) { }
    }
    public class NotFoundException : ApiException
    {
        public NotFoundException(string message) : base(message) { }
    }
    public class BadRequestException : ApiException
    {
        public BadRequestException(string message) : base(message) { }
    }

    public class UpdateRequestException : ApiException
    {
        public UpdateRequestException(string message) : base(message) { }
    }

    public class DeleteRequestException : ApiException
    {
        public DeleteRequestException(string message) : base(message) { }
    }

    public class UnauthorizeException : ApiException
    {
        public UnauthorizeException() : base() {}
        public UnauthorizeException(string message) : base(message) { }
    }

    public class AuthFailedException : ApiException
    {
        public AuthFailedException() : base() { }
        public AuthFailedException(string message) : base(message) { }
    }

    public class ValidationException : ApiException
    {
        public ValidationException() : base("One or more validation failures have occurred.")
        {
            Errors = new List<string>();
        }
        public List<string> Errors { get; }
        public ValidationException(IEnumerable<ValidationFailure> failures)
            : this()
        {
            foreach (var failure in failures)
            {
                Errors.Add(failure.ErrorMessage);
            }
        }

    }
}
