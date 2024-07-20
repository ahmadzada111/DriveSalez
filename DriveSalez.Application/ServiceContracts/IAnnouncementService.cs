using DriveSalez.Application.DTO;
using DriveSalez.Application.DTO.AccountDTO;
using DriveSalez.Application.DTO.AnnoucementDTO;
using DriveSalez.Application.DTO.AnnouncementDTO;
using DriveSalez.Domain.Enums;
using DriveSalez.Domain.Pagination;

namespace DriveSalez.Application.ServiceContracts;

public interface IAnnouncementService
{
    Task<AnnouncementResponseDto?> CreateAnnouncementAsync(CreateAnnouncementDto createAnnouncement);

    Task<AnnouncementResponseDto?> UpdateAnnouncementAsync(Guid announcementId, UpdateAnnouncementDto request);

    Task<AnnouncementResponseDto?> DeleteInactivateAnnouncementAsync(Guid announcementId);

    Task<AnnouncementResponseDto?> MakeAnnouncementActiveAsync(Guid announcementId);
    
    Task<AnnouncementResponseDto?> MakeAnnouncementInactiveAsync(Guid announcementId);
    
    Task<AnnouncementResponseDto?> GetAnnouncementByIdAsync(Guid id);

    Task<AnnouncementResponseDto?> GetActiveAnnouncementByIdAsync(Guid id);
    
    Task<Tuple<IEnumerable<AnnouncementResponseMiniDto>, IEnumerable<AnnouncementResponseMiniDto>>> GetAllActiveAnnouncements(PagingParameters parameters);

    Task<IEnumerable<AnnouncementResponseMiniDto>> GetFilteredAnnouncementsAsync(FilterParameters filterParameters, PagingParameters pagingParameters);

    Task<IEnumerable<AnnouncementResponseMiniDto>> GetAnnouncementsByStatesAndByUserAsync(PagingParameters pagingParameters, AnnouncementState announcementState);

    Task<IEnumerable<AnnouncementResponseMiniDto>> GetAllAnnouncementsByUserAsync(PagingParameters pagingParameters);

    Task<IEnumerable<AnnouncementResponseMiniDto>> GetAllPremiumAnnouncementsAsync(PagingParameters pagingParameters);

    Task<LimitRequestDto> GetUserLimitsAsync();

    Task<IEnumerable<AnnouncementResponseMiniDto>> GetAllAnnouncementsForAdminPanelAsync(PagingParameters parameters, AnnouncementState announcementState);
}