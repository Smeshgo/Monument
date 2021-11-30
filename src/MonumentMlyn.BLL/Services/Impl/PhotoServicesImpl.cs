﻿using AutoMapper;
using MonumentMlyn.BLL.DTO;
using MonumentMlyn.DAL.Entities;
using MonumentMlyn.DAL.Repositorie;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace MonumentMlyn.BLL.Services.Impl
{
    public class PhotoServicesImpl : IPhotoServices
    {
        private readonly IUnitOfWork _repository;
        private readonly IMapper _mapper;

        public PhotoServicesImpl(IUnitOfWork repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<IEnumerable<PhotoDto>> GetAllPhotos()
        {
            var photos =
                _mapper.Map<IEnumerable<Photo>, IEnumerable<PhotoDto>>(
                    await _repository.Photo.GetAllPhoto(trackChanges: false));

            return _mapper.Map<IEnumerable<PhotoDto>>(photos);
        }

        public async Task<IEnumerable<PhotoDto>> GetAllMinyPhoto(int category)
        {
            var photos =
                _mapper.Map<IEnumerable<Photo>, IEnumerable<PhotoDto>>(
                    await _repository.Photo.GetAllMinyPhoto(trackChanges: false,category));

            return _mapper.Map<IEnumerable<PhotoDto>>(photos);
        }
        public async Task<PhotoDto> GetPhotoById(Guid photoId)
        {
            var photo = await _repository.Photo.GetPhotoById(photoId);

            return _mapper.Map<PhotoDto>(photo);
        }

        public async Task<IEnumerable<PhotoDto>> GetCategoryPhotos(int category)
        {
            var photos = await _repository.Photo.GetCategoryPhoto(category);
            return _mapper.Map<IEnumerable<PhotoDto>>(photos);
        }
        private static async Task<byte[]> ImageToBase64(IFormFile imgFile)
        {
            byte[] imgBase64;
            await using var fs1 = imgFile.OpenReadStream();
            await using var ms1 = new MemoryStream();
            fs1.CopyTo(ms1);
            imgBase64 = ms1.ToArray();

            return imgBase64;
        }

        public async Task CreatePhoto(IFormFile imgFull, IFormFile imgMyni, string name, int category)
        {
            var photoEntity = new Photo()
            {
                PhotoId = Guid.NewGuid(),
                Name = name,
                CreatePhoto = DateTime.Now,
                UpdatePhoto = DateTime.Now,
                CategoryPhoto = (DAL.Enum.CategoryPhoto)category,
                FullPhoto = ImageToBase64(imgMyni).Result,
                MinyPhoto = ImageToBase64(imgFull).Result

            };

            _repository.Photo.CreatePhoto(photoEntity);
            await _repository.SaveAsync();
        }

        public async Task UpdatePhoto(Guid photoId, PhotoRequest photo)
        {
            var photoEntity = new Photo()
            {
                Name = photo.Name,
                UpdatePhoto = DateTime.Now,
                CategoryPhoto = photo.CategoryPhoto,
                FullPhoto = ImageToBase64(photo.PathFull).Result,
                MinyPhoto = ImageToBase64(photo.PathMini).Result
            };

            
            _repository.Photo.UpdatePhoto(photoEntity);
            await _repository.SaveAsync();
        }

        public async Task DeletePhoto(Guid photoId)
        {
            var photoEntity = await _repository.Photo.GetPhotoById(photoId);

            _repository.Photo.DeletePhoto(photoEntity);
            await _repository.SaveAsync();
        }
    }
}